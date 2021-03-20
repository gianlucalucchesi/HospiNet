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
    public partial class ManageAttendancesControl : UserControl
    {
        private Guid? DoctorId;

        public ManageAttendancesControl(Guid? DoctorId)
        {
            InitializeComponent();
            this.DoctorId = DoctorId;
        }

        private void checkBox_AllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AlLDay.Checked)
            {
                comboBox_FromHour.Enabled = false;
                comboBox_FromMinutes.Enabled = false;
                comboBox_ToHour.Enabled = false;
                comboBox_ToMinutes.Enabled = false;
            }
            else
            {
                comboBox_FromHour.Enabled = true;
                comboBox_FromMinutes.Enabled = true;
                comboBox_ToHour.Enabled = true;
                comboBox_ToMinutes.Enabled = true;
            }
        }

        private void comboBox_FromMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEndTime();
        }

        private void comboBox_FromHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEndTime();
        }

        private void ShowEndTime()
        {
            label_Failed.Visible = false;

            if (comboBox_FromHour.SelectedIndex != -1 || comboBox_FromMinutes.SelectedIndex != -1)
            {
                Int32.TryParse(comboBox_FromHour.Text, out int fromHour);
                comboBox_ToHour.Items.Clear();

                for (int i = fromHour; i < 19; i++) //19 to include 18h00
                {
                    comboBox_ToHour.Items.Add(i.ToString());
                }

                comboBox_ToHour.Enabled = true;
                comboBox_ToMinutes.Enabled = true;
            }
        }

        private void comboBox_ToHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Failed.Visible = false;

            //Time cannot go past 18h00
            if (comboBox_ToHour.Text == "18")
            {
                comboBox_ToMinutes.Items.Clear();
                comboBox_ToMinutes.Items.Add("00");
                comboBox_ToMinutes.SelectedIndex = 0;
            }
            else
            {
                comboBox_ToMinutes.Items.Clear();
                this.comboBox_ToMinutes.Items.AddRange(new object[] {
                    "00",
                    "05",
                    "10",
                    "15",
                    "20",
                    "25",
                    "30",
                    "35",
                    "40",
                    "45",
                    "50",
                    "55"}
                );
            } 
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

        private async void ManageAttendancesControl_Load(object sender, EventArgs e)
        {
            var hospitals = await GetAllHospitals();

            foreach (var hospital in hospitals)
            {
                comboBox_Hospitals.Items.Add(hospital.Name);
            }
        }

        private void comboBox_ToMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Failed.Visible = false;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            Double.TryParse(comboBox_FromHour.SelectedItem.ToString(), out double fromHour);
            Double.TryParse(comboBox_FromMinutes.SelectedItem.ToString(), out double fromMinutes);
            Double.TryParse(comboBox_ToHour.SelectedItem.ToString(), out double toHour);
            Double.TryParse(comboBox_ToMinutes.SelectedItem.ToString(), out double toMinutes);

            DateTime timeStart = monthCalendar_AttendanceDay.SelectionRange.Start.AddHours(fromHour).AddMinutes(fromMinutes);
            DateTime timeEnd = monthCalendar_AttendanceDay.SelectionRange.Start.AddHours(toHour).AddMinutes(toMinutes);

            if (timeStart > timeEnd)
            {
                label_Failed.Visible = true;
            }
            else
            {
                var attendance = new
                {
                    doctorId = this.DoctorId,
                    hospitalName = comboBox_Hospitals.Text,
                    timestart = timeStart,
                    timeEnd = timeEnd
                };

                //TODO API call Post Attendance

                label_Success.Visible = true;
            }
        }
    }
}
