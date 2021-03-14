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

namespace HospiNetApp.UserControls.DoctorDashboard
{
    public partial class ManageAppointmentsControl : UserControl
    {
        private Guid? DoctorId;
        public ManageAppointmentsControl(Guid? DoctorId)
        {
            InitializeComponent();
            this.DoctorId = DoctorId;
        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            GetAppointments(this.DoctorId);
        }

        private async void GetAppointments(Guid? DoctorId)
        {
            const string apiRequest = "https://localhost:44310/api/doctors/GetAppointments";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?DoctorId={DoctorId}");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        List<Models.ModAppointmentVw> lstContent = JsonConvert.DeserializeObject<List<Models.ModAppointmentVw>>(content);

                        int i = 0;

                        foreach (var appointment in lstContent)
                        {
                            dataGridView_Appointments[0, i].Value = appointment.HospitalName;
                            dataGridView_Appointments[1, i].Value = appointment.RoomName;
                            dataGridView_Appointments[2, i].Value = appointment.FirstName + " " + appointment.LastName;
                            dataGridView_Appointments[3, i].Value = appointment.DateTimeStart;
                            dataGridView_Appointments[4, i].Value = appointment.DateTimeEnd;
                            dataGridView_Appointments[5, i].Value = appointment.Confirmed;
                            i++;
                        }

                        label_loading.Visible = false;
                        dataGridView_Appointments.Visible = true;
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
