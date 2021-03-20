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
        Models.ModPatient Patient;

        public NewAppointmentControl()
        {
            InitializeComponent();
        }

        private async void NewAppointment_Load(object sender, EventArgs e)
        {
            var hospitals = await GetAllHospitals();

            foreach (var hospital in hospitals)
            {
                comboBox_Hospitals.Items.Add(hospital.Name);
            }

            GetAvailabilities(15.00);
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

        private async Task<List<Models.ModHospital>> GetAllHospitals()
        {
            List<Models.ModHospital> lstContent = new List<Models.ModHospital>();
            const string apiRequest = "https://localhost:44310/api/hospitals/GetAllHospitals";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        lstContent = JsonConvert.DeserializeObject<List<Models.ModHospital>>(content);
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
            Double.TryParse(comboBox_AppointmentHour.SelectedItem.ToString(), out double hours);
            Double.TryParse(comboBox_AppointmentMinutes.SelectedItem.ToString(), out double minutes);

            NewAppointment.Patient.FirstName = textBox_patientFirstName.Text;
            NewAppointment.Patient.LastName = textBox_patientLastName.Text;
            NewAppointment.Patient.Birthday = dateTimePicker_patientBirthday.Value;
            //NewAppointment.DateTimeStart = monthCalendar_AppointmentDate.SelectionRange.Start.AddHours(hours).AddMinutes(minutes);
            //NewAppointment.DoctorName = comboBox_Doctors.SelectedItem.ToString();
            NewAppointment.HospitalName = comboBox_Hospitals.SelectedItem.ToString();

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
            int appointmentId = -1;
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

        private void GetAvailabilities(List<DateTime> notAvailble, double duration)
        {
            DateTime dt = monthCalendar_AppointmentDate.SelectionRange.Start.AddHours(8.00);

            Console.WriteLine(dt.Hour.ToString());
            Console.WriteLine(dt.Minute.ToString());

            while (dt.Hour != 18) //Day finished at 18h00
            {
                if (dt.Minute == 0)
                    comboBox_Availabilities.Items.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString() + "0");
                else
                    comboBox_Availabilities.Items.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString());

                dt = dt.AddMinutes(duration);
            }
        }

        private void GetAvailabilities(double duration)
        {
            DateTime dt = monthCalendar_AppointmentDate.SelectionRange.Start.AddHours(8.00);

            Console.WriteLine(dt.Hour.ToString());
            Console.WriteLine(dt.Minute.ToString());

            while (dt.Hour != 18) //Day finished at 18h00
            {
               if (dt.Minute == 0)
                    comboBox_Availabilities.Items.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString()+"0");
                else
                    comboBox_Availabilities.Items.Add(dt.Hour.ToString() + ":" + dt.Minute.ToString());

                dt = dt.AddMinutes(duration);
            }
        }
    }
}
