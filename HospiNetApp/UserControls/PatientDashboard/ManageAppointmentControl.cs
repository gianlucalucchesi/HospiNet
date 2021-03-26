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
        public ManageAppointmentControl()
        {
            InitializeComponent();
        }

        private async void pictureBox_search_ClickAsync(object sender, EventArgs e)
        {
            Models.ModAppointment appointment = await GetAppointment();

            if (appointment.DoctorName != null)
            {
                ShowAppointment(appointment);
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

            if (!appointment.Confirmed)
            {
                comboBox_Specialities.Enabled = true;
                comboBox_Doctors.Enabled = true;
                comboBox_Hospitals.Enabled = true;
                button_update.Enabled = true;
                button_cancel.Enabled = true;
                label_Confirmed.Visible = false;
                label_NotFound.Visible = false;
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
    }
}
