using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.UserControls.PatientDashboard
{
    public partial class NewAppointmentControl : UserControl
    {
        Models.ModAppointment NewAppointment;
        List<Models.ModHospital> lstAvailableHospitals;
        Dictionary<string, DateTime> AppointmentTimeSlot = new Dictionary<string, DateTime>();

        public NewAppointmentControl()
        {
            InitializeComponent();
        }

        private async void NewAppointment_Load(object sender, EventArgs e)
        {
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

        private async void comboBox_Specialities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset combobox in case of speciality change
            comboBox_Doctors.Enabled = false;
            comboBox_Doctors.Items.Clear();
            comboBox_Doctors.Text = "";

            string speciality = comboBox_Specialities.SelectedItem.ToString();

            List<Models.ModDoctor> lstDoctor = await GetDoctorsBasedOnSpeciality(speciality);

            foreach (var doctor in lstDoctor)
            {
                comboBox_Doctors.Items.Add(doctor.FirstName + " " + doctor.LastName);
            }

            comboBox_Doctors.Enabled = true;
        }

        private async void button_AddAppointment_Click(object sender, EventArgs e)
        {
            NewAppointment = new Models.ModAppointment() 
            { 
                Id = null, 
                Confirmed = false 
            };

            NewAppointment.Patient = new Models.ModPatient();
            NewAppointment.Patient.FirstName = textBox_patientFirstName.Text;
            NewAppointment.Patient.LastName = textBox_patientLastName.Text;
            NewAppointment.Patient.Birthday = dateTimePicker_patientBirthday.Value;
            NewAppointment.DateTimeStart = AppointmentTimeSlot[comboBox_Availabilities.SelectedItem.ToString()];
            NewAppointment.HospitalName = comboBox_Hospitals.SelectedItem.ToString();
            NewAppointment.SpecialityName = comboBox_Specialities.SelectedItem.ToString();

            int appointmentId = await PostAppointment(NewAppointment);

            if (appointmentId != -1)
            {
                label_SuccessFailed.Text = "Appointment created: " + appointmentId.ToString();
            }
            else
            {
                label_SuccessFailed.ForeColor = Color.DarkRed;
                label_SuccessFailed.Text = "Conflict";
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

        private void ShowAvailabilities(double duration)
        {
            DateTime dt = monthCalendar_AppointmentDate.SelectionRange.Start.AddHours(8.00);
            comboBox_Availabilities.Items.Clear();
            button_AddAppointment.Enabled = false;

            while (dt.Hour != 18) //Consultations end at 18h00
            {
                if (dt.Minute == 0)
                {
                    comboBox_Availabilities.Items.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString() + "0");
                    AppointmentTimeSlot.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString() + "0", dt);
                }
                else
                {
                    comboBox_Availabilities.Items.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString());
                    AppointmentTimeSlot.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString(), dt);
                }

                dt = dt.AddMinutes(duration);
            }

            if (comboBox_Availabilities.Items.Count == 0)
                comboBox_Availabilities.Items.Add("No availabilities");
            else
                button_AddAppointment.Enabled = true;
                

            comboBox_Availabilities.SelectedIndex = 0;
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

        private void comboBox_Hospitals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_Specialities.SelectedItem.ToString() != ""
                    && comboBox_Doctors.SelectedItem.ToString() != ""
                    && comboBox_Hospitals.SelectedItem.ToString() != "")
                comboBox_Availabilities.Enabled = true;
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
    }
}
