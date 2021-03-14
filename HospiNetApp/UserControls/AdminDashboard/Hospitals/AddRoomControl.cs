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

namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
{
    public partial class AddRoomControl : UserControl
    {
        public AddRoomControl()
        {
            InitializeComponent();
        }

        private void textBox_RoomName_TextChanged(object sender, EventArgs e)
        {
            comboBox_Hospitals.Enabled = true; 
            label_Success.Visible = false;
            label_Failed.Visible = false;
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

        private async void AddRoomControl_Load(object sender, EventArgs e)
        {
            var hospitals = await GetAllHospitals();

            foreach (var hospital in hospitals)
            {
                comboBox_Hospitals.Items.Add(hospital.Name);
            }
        }

        private async void button_AddRoom_Click(object sender, EventArgs e)
        {
            string sRoomName = textBox_RoomName.Text;
            string sHospitalName = comboBox_Hospitals.SelectedItem.ToString();

            const string apiRequest = "https://localhost:44310/api/hospitals/AddRoom";

            var room = new
            {
                roomName = sRoomName,
                hospitalName = sHospitalName
            };

            var content = JsonConvert.SerializeObject(room);

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                        label_Success.Visible = true;
                    else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                        label_Failed.Visible = true;
                }
            }
            catch (OperationCanceledException exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }

            // Clear form
            textBox_RoomName.Text = "";
            comboBox_Hospitals.SelectedIndex = -1;
        }
    }
}
