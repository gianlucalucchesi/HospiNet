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
            label_ConfirmedSuccess.Visible = false;
            List<Models.ModAppointmentVw> lstAllAppointments = await GetAppointments(this.DoctorId);
            ShowAppointments(lstAllAppointments);
        }

        private async Task<List<Models.ModAppointmentVw>> GetAppointments(Guid? DoctorId)
        {
            const string apiRequest = "https://localhost:44310/api/doctors/GetAppointments";
            List<Models.ModAppointmentVw> lstContent = new List<Models.ModAppointmentVw>();

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?DoctorId={DoctorId}");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        lstContent = JsonConvert.DeserializeObject<List<Models.ModAppointmentVw>>(content);
                    }
                }
            }
            catch (HttpRequestException exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }

            return lstContent;
        }

        private async void button_Confirm_Click(object sender, EventArgs e)
        {
            int appointmentId = 0;
            const string apiRequest = "https://localhost:44310/api/doctors/ConfirmAppointment";

            foreach (DataGridViewRow row in dataGridView_Appointments.SelectedRows)
            {
                Int32.TryParse(row.Cells[0].Value.ToString(), out appointmentId);
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?appointmentId={appointmentId}");

                    if (response.IsSuccessStatusCode)
                    {
                        label_ConfirmedSuccess.Visible = true;
                    }
                }
            }
            catch (HttpRequestException exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        private void dataGridView_Appointments_SelectionChanged(object sender, EventArgs e)
        {
            if (label_ConfirmedSuccess.Visible)
             label_ConfirmedSuccess.Visible = false;
        }

        private async void checkBox_ConfirmedUnconfirmedAppointment_CheckedChanged(object sender, EventArgs e)
        {
            label_ConfirmedSuccess.Visible = false;
            List<Models.ModAppointmentVw> lstAllAppointments = await GetAppointments(this.DoctorId);
            List<Models.ModAppointmentVw> lstAppointments = new List<Models.ModAppointmentVw>();

            if (checkBox_ConfirmedUnconfirmedAppointment.Checked)
            {
                foreach (var appointment in lstAllAppointments)
                {
                    if (appointment.Confirmed)
                        lstAppointments.Add(appointment);
                }

                ShowAppointments(lstAppointments);
            } 
            else
            {
                ShowAppointments(lstAllAppointments);
            }
                
        }

        private void ShowAppointments(List<Models.ModAppointmentVw> lstAppointments)
        {
            int i = 0;
            dataGridView_Appointments.Rows.Clear();
            dataGridView_Appointments.Visible = false;
            label_loading.Visible = true;

            foreach (var appointment in lstAppointments)
            {
                if(appointment.DateTimeStart.ToShortDateString() == monthCalendar1.SelectionRange.Start.ToShortDateString())
                {
                    dataGridView_Appointments[0, i].Value = appointment.HospitalName;
                    dataGridView_Appointments[1, i].Value = appointment.RoomName;
                    dataGridView_Appointments[2, i].Value = appointment.FirstName + " " + appointment.LastName;
                    dataGridView_Appointments[3, i].Value = appointment.DateTimeStart;
                    dataGridView_Appointments[4, i].Value = appointment.DateTimeEnd;
                    dataGridView_Appointments[5, i].Value = appointment.Confirmed;
                }
                i++;
            }

            label_loading.Visible = false;
            dataGridView_Appointments.Visible = true;
        }

        private async void ManageAppointmentsControl_Load(object sender, EventArgs e)
        {
            ShowAppointments(await GetAppointments(this.DoctorId));
        }
    }
}
