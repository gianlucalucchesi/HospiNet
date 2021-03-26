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
            this.OldAppointment = await GetAppointment();

            if (this.OldAppointment.DoctorName != null)
            {
                ShowAppointment(this.OldAppointment);
            }
        }

        private async Task<Models.ModAppointment> GetAppointment()
        {
            Models.ModAppointment appointment = new Models.ModAppointment();
            const string apiRequest = "https://localhost:44310/api/appointments/GetAppointment";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?id={textBox_ReservationCode.Text}");

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        appointment = JsonConvert.DeserializeObject<Models.ModAppointment>(content);
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

            return appointment;
        }

        private void ShowAppointment(Models.ModAppointment appointment)
        {
            comboBox_Specialities.SelectedItem = appointment.SpecialityName;

            comboBox_Doctors.Items.Add(appointment.DoctorName);
            comboBox_Doctors.SelectedIndex = 0;

            comboBox_Hospitals.Items.Add(appointment.HospitalName);
            comboBox_Hospitals.SelectedIndex = 0;

            monthCalendar_AppointmentDate.SetDate(appointment.DateTimeStart.Date);
            comboBox_Availabilities.Text = appointment.DateTimeStart.ToShortTimeString() + " - " + appointment.DateTimeEnd.ToShortTimeString();

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
            const string apiRequest = "https://localhost:44310/api/appointments/CancelAppointment";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"{apiRequest}/?id={textBox_ReservationCode.Text}");
                    
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        label_NotFound.Visible = false;
                        label_SuccessFailed.Text = "Appointment cancelled";
                        label_SuccessFailed.Visible = true;
                        comboBox_Doctors.Items.Clear();
                        comboBox_Doctors.Text = "";
                        comboBox_Hospitals.Items.Clear();
                        comboBox_Hospitals.Text = "";
                        comboBox_Specialities.Text = "";
                        textBox_ReservationCode.Text = "";
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
            comboBox_Hospitals.Items.Clear();
            lstAvailableHospitals = await GetAvailableHospitals(comboBox_Doctors.Text, comboBox_Specialities.Text);

            foreach (var hospital in lstAvailableHospitals)
            {
                if (!comboBox_Hospitals.Items.Contains(hospital.Name))
                    comboBox_Hospitals.Items.Add(hospital.Name);
            }

            if (lstAvailableHospitals.Count == 0)
                comboBox_Hospitals.Items.Add("No available hospitals");

            comboBox_Hospitals.Enabled = true;
        }

        private async void comboBox_Hospitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Specialities.SelectedItem.ToString() != ""
                && comboBox_Doctors.SelectedItem.ToString() != ""
                && comboBox_Hospitals.SelectedItem.ToString() != "")
            {
                var timeslots = await GetAvailableTimeSlots(
                    comboBox_Doctors.SelectedItem.ToString(),
                    comboBox_Specialities.SelectedItem.ToString(),
                    comboBox_Hospitals.SelectedItem.ToString(),
                    monthCalendar_AppointmentDate.SelectionRange.Start);

                ShowAvailableTimeSlots(timeslots);
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

        private async void comboBox_Specialities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO DELETE OLD APPOINTMENT FIRST 

            //NewAppointment = new Models.ModAppointment()
            //{
            //    Id = null,
            //    Confirmed = false
            //};

            //NewAppointment.Patient = new Models.ModPatient();
            //NewAppointment.Patient.FirstName = this.OldAppointment.Patient.FirstName;
            //NewAppointment.Patient.LastName = this.OldAppointment.Patient.LastName;
            //NewAppointment.Patient.Birthday = this.OldAppointment.Patient.Birthday;
            //NewAppointment.DoctorName = comboBox_Doctors.SelectedItem.ToString();
            //NewAppointment.DateTimeStart = AppointmentTimeSlot[comboBox_Availabilities.SelectedItem.ToString()][0];
            //NewAppointment.DateTimeEnd = AppointmentTimeSlot[comboBox_Availabilities.SelectedItem.ToString()][1];
            //NewAppointment.HospitalName = comboBox_Hospitals.SelectedItem.ToString();
            //NewAppointment.SpecialityName = comboBox_Specialities.SelectedItem.ToString();

            //int appointmentId = await PostAppointment(NewAppointment);

            //if (appointmentId != -1)
            //{
            //    label_SuccessFailed.Text = "Appointment updated: " + appointmentId.ToString();
            //    label_SuccessFailed.Visible = true;
            //}
            //else
            //{
            //    label_SuccessFailed.ForeColor = Color.DarkRed;
            //    label_SuccessFailed.Text = "Conflict";
            //}
        }
    }
}
