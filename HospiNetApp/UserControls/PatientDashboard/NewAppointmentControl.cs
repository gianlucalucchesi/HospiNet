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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
