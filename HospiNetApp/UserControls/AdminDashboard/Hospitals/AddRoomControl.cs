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
    }
}
