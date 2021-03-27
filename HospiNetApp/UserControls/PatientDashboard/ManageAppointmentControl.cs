using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.UserControls.PatientDashboard
{
    public partial class ManageAppointmentControl : UserControl
    {
        Models.ModAppointment OldAppointment;
        Models.ModAppointment NewAppointment;
        List<Models.ModHospital> lstAvailableHospitals;
        Dictionary<string, DateTime[]> AppointmentTimeSlot = new Dictionary<string, DateTime[]>();

        public ManageAppointmentControl()
        {
            InitializeComponent();
        }

        private async void pictureBox_search_ClickAsync(object sender, EventArgs e)
        {
            label_loading.Visible = true;
            this.OldAppointment = await GetAppointment();

            if (this.OldAppointment.DoctorName != null)
            {
                ShowAppointment(this.OldAppointment);
            }

            label_loading.Visible = false;
        }

        private async Task<Models.ModAppointment> GetAppointment()
        {
            Models.ModAppointmentVw appointmentReceived = new Models.ModAppointmentVw();
            Models.ModAppointment appointmentToReturn = new Models.ModAppointment();
            const string apiRequest = "https://localhost:44310/api/appointments/GetAppointment";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?id={textBox_ReservationCode.Text}");

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        appointmentReceived = JsonConvert.DeserializeObject<Models.ModAppointmentVw>(content);

                        appointmentToReturn.Patient = new Models.ModPatient();
                        appointmentToReturn.HospitalName = appointmentReceived.HospitalName;
                        appointmentToReturn.RoomName = appointmentReceived.RoomName;
                        appointmentToReturn.Confirmed = appointmentReceived.Confirmed;
                        appointmentToReturn.DateTimeStart = appointmentReceived.DateTimeStart;
                        appointmentToReturn.DateTimeEnd = appointmentReceived.DateTimeEnd;
                        appointmentToReturn.Patient.FirstName = appointmentReceived.FirstName;
                        appointmentToReturn.Patient.LastName = appointmentReceived.LastName;
                        appointmentToReturn.Patient.Birthday = appointmentReceived.Birthday;
                        appointmentToReturn.SpecialityName = appointmentReceived.SpecialityName;
                        appointmentToReturn.DoctorName = appointmentReceived.DoctorName;

                        label_NotFound.Visible = false;
                    }
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        label_NotFound.Visible = true;
                        label_Confirmed.Visible = false;
                    }
                }
            }
            catch (HttpRequestException exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }

            return appointmentToReturn;
        }

        private void ShowAppointment(Models.ModAppointment appointment)
        {
            monthCalendar_AppointmentDate.SetDate(this.OldAppointment.DateTimeStart.Date);
            comboBox_Availabilities.Text = this.OldAppointment.DateTimeStart.ToShortTimeString() + " - " + this.OldAppointment.DateTimeEnd.ToShortTimeString();

            comboBox_Specialities.SelectedItem = this.OldAppointment.SpecialityName;

            comboBox_Doctors.Items.Add(this.OldAppointment.DoctorName);
            comboBox_Doctors.SelectedIndex = 0;

            comboBox_Hospitals.Items.Add(this.OldAppointment.HospitalName);
            comboBox_Hospitals.SelectedIndex = 0;

            if (!appointment.Confirmed)
            {
                comboBox_Specialities.Enabled = true;
                comboBox_Doctors.Enabled = true;
                comboBox_Hospitals.Enabled = true;
                button_update.Enabled = true;
                button_cancel.Enabled = true;
                label_Confirmed.Visible = false;
                label_NotFound.Visible = false;
                monthCalendar_AppointmentDate.Enabled = true;
                comboBox_Availabilities.Enabled = true;
            }
            else
            {
                label_Confirmed.Visible = true;
            }
        }

        private async void button_cancel_Click(object sender, EventArgs e)
        {
            CancelAppointment(true);
        }

        private async void CancelAppointment(bool showVisualConfirmation)
        {
            const string apiRequest = "https://localhost:44310/api/appointments/CancelAppointment";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"{apiRequest}/?id={textBox_ReservationCode.Text}");

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;

                        if (showVisualConfirmation)
                        {
                            label_SuccessFailed.Text = "Appointment cancelled";
                            label_SuccessFailed.Visible = true;
                            comboBox_Doctors.Items.Clear();
                            comboBox_Doctors.Text = "";
                            comboBox_Hospitals.Items.Clear();
                            comboBox_Hospitals.Text = "";
                            comboBox_Specialities.Text = "";
                            textBox_ReservationCode.Text = "";
                        }
                    }
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        label_NotFound.Visible = true;
                        label_Confirmed.Visible = false;
                        label_SuccessFailed.Visible = false;
                    }
                }
            }
            catch (HttpRequestException exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        private async Task<int> PostAppointment(Models.ModAppointment newAppointment)
        {
            int appointmentId = -99;
            const string apiRequest = "https://localhost:44310/api/appointments/add";

            string content = JsonConvert.SerializeObject(newAppointment);

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                        Int32.TryParse(response.Content.ReadAsStringAsync().Result, out appointmentId);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return appointmentId;
        }

        private async void comboBox_Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!OldAppointment.Confirmed)
            {
                comboBox_Hospitals.Items.Clear();
                comboBox_Hospitals.Text = "";
                label_loading.Visible = true;
                lstAvailableHospitals = await GetAvailableHospitals(comboBox_Doctors.Text, comboBox_Specialities.Text);

                foreach (var hospital in lstAvailableHospitals)
                {
                    if (!comboBox_Hospitals.Items.Contains(hospital.Name))
                        comboBox_Hospitals.Items.Add(hospital.Name);
                }

                if (lstAvailableHospitals.Count == 0)
                    comboBox_Hospitals.Items.Add("No available hospitals");

                label_loading.Visible = false;
                comboBox_Hospitals.Enabled = true;
            }
        }

        private async void comboBox_Hospitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!OldAppointment.Confirmed)
            {
                if (comboBox_Specialities.SelectedItem.ToString() != ""
                    && comboBox_Doctors.SelectedItem.ToString() != ""
                    && comboBox_Hospitals.SelectedItem.ToString() != "")
                {
                    label_loading.Visible = true;
                    var timeslots = await GetAvailableTimeSlots(
                        comboBox_Doctors.SelectedItem.ToString(),
                        comboBox_Specialities.SelectedItem.ToString(),
                        comboBox_Hospitals.SelectedItem.ToString(),
                        monthCalendar_AppointmentDate.SelectionRange.Start);

                    ShowAvailableTimeSlots(timeslots);
                    label_loading.Visible = false;
                }
            }
        }

        private async Task<List<Models.ModHospital>> GetAvailableHospitals(string doctorName, string specialityName)
        {
            List<Models.ModHospital> lst = new List<Models.ModHospital>();

            const string apiRequest = "https://localhost:44310/api/appointments/GetAvailableHospitals";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?doctorName={doctorName}&specialityName={specialityName}");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        if (content != "null")
                            lst = JsonConvert.DeserializeObject<List<Models.ModHospital>>(content);
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return lst;
        }

        private async Task<List<DateTime[]>> GetAvailableTimeSlots(string doctorName, string specialityName, string hospitalName, DateTime day)
        {
            List<DateTime[]> lst = new List<DateTime[]>();

            const string apiRequest = "https://localhost:44310/api/appointments/GetAvailableTimeSlots";

            try
            {
                using (var client = new HttpClient())
                {
                    var response =
                        await client.GetAsync($"{apiRequest}/?doctorName={doctorName}&specialityName={specialityName}&hospitalName={hospitalName}&day={day.ToShortDateString()}");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        if (content != "null")
                            lst = JsonConvert.DeserializeObject<List<DateTime[]>>(content);
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return lst;
        }

        private void ShowAvailableTimeSlots(List<DateTime[]> timeSlots)
        {
            if (!OldAppointment.Confirmed) 
            {
                comboBox_Availabilities.Enabled = false;
                comboBox_Availabilities.Items.Clear();
                comboBox_Availabilities.Text = "";
                AppointmentTimeSlot.Clear();

                foreach (var timeSlot in timeSlots)
                {
                    AppointmentTimeSlot.Add(timeSlot[0].ToShortTimeString() + " - " + timeSlot[1].ToShortTimeString(), timeSlot);
                }

                foreach (var timeSlot in AppointmentTimeSlot)
                {
                    comboBox_Availabilities.Items.Add(timeSlot.Key);
                }

                if (comboBox_Availabilities.Items.Count == 0)
                    comboBox_Availabilities.Items.Add("No availabilities");

                comboBox_Availabilities.Enabled = true;
            }

            comboBox_Availabilities.Text = this.OldAppointment.DateTimeStart.ToShortTimeString() + " - " + this.OldAppointment.DateTimeEnd.ToShortTimeString();
        }

        private async void comboBox_Specialities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!OldAppointment.Confirmed)
            {
                // Reset combobox in case of speciality change
                comboBox_Doctors.Enabled = false;
                comboBox_Doctors.Items.Clear();
                comboBox_Doctors.Text = "";
                comboBox_Hospitals.Items.Clear();
                comboBox_Hospitals.Text = "";
                label_loading.Visible = true;

                string speciality = comboBox_Specialities.SelectedItem.ToString();

                List<Models.ModDoctor> lstDoctor = await GetDoctorsBasedOnSpeciality(speciality);

                foreach (var doctor in lstDoctor)
                {
                    comboBox_Doctors.Items.Add(doctor.FirstName + " " + doctor.LastName);
                }

                if (lstDoctor.Count == 0)
                    comboBox_Doctors.Items.Add("No available doctors");

                comboBox_Doctors.Enabled = true;
                label_loading.Visible = false;
            }
        }

        private async Task<List<Models.ModDoctor>> GetDoctorsBasedOnSpeciality(string pSpeciality)
        {
            List<Models.ModDoctor> lstContent = new List<Models.ModDoctor>();
            const string apiRequest = "https://localhost:44310/api/doctors/getDoctorBasedOnSpeciality";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?speciality={pSpeciality}");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        lstContent = JsonConvert.DeserializeObject<List<Models.ModDoctor>>(content);
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return lstContent;
        }

        private async void button_update_Click(object sender, EventArgs e)
        {
            NewAppointment = new Models.ModAppointment()
            {
                Id = null,
                Confirmed = false
            };

            NewAppointment.Patient = new Models.ModPatient();
            NewAppointment.Patient.FirstName = this.OldAppointment.Patient.FirstName;
            NewAppointment.Patient.LastName = this.OldAppointment.Patient.LastName;
            NewAppointment.Patient.Birthday = this.OldAppointment.Patient.Birthday;
            NewAppointment.DoctorName = comboBox_Doctors.Text;
            NewAppointment.DateTimeStart = AppointmentTimeSlot[comboBox_Availabilities.SelectedItem.ToString()][0];
            NewAppointment.DateTimeEnd = AppointmentTimeSlot[comboBox_Availabilities.SelectedItem.ToString()][1];
            NewAppointment.HospitalName = comboBox_Hospitals.SelectedItem.ToString();
            NewAppointment.SpecialityName = comboBox_Specialities.SelectedItem.ToString();

            int appointmentId = await PostAppointment(NewAppointment);

            if (appointmentId != -1)
            {
                label_SuccessFailed.Text = "Appointment updated: " + appointmentId.ToString();
                CancelAppointment(false);
                label_SuccessFailed.Visible = true;
            }
            else
            {
                label_SuccessFailed.ForeColor = Color.DarkRed;
                label_SuccessFailed.Text = "Conflict";
            }
        }

        private async void monthCalendar_AppointmentDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (comboBox_Hospitals.Enabled && comboBox_Hospitals.SelectedItem.ToString() != "")
            {
                var timeslots = await GetAvailableTimeSlots(
                    comboBox_Doctors.SelectedItem.ToString(),
                    comboBox_Specialities.SelectedItem.ToString(),
                    comboBox_Hospitals.SelectedItem.ToString(),
                    monthCalendar_AppointmentDate.SelectionRange.Start);

                ShowAvailableTimeSlots(timeslots);
            }
        }
    }
}
