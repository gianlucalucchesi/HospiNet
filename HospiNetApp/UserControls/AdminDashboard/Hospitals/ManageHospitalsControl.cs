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
    public partial class ManageHospitalsControl : UserControl
    {
        public ManageHospitalsControl()
        {
            InitializeComponent();
        }

        private void button_AddHospital_Click(object sender, EventArgs e)
        {
            AddHospitalControl oControl = new AddHospitalControl();
            MainControl.showControl(oControl, panel_ManageHospitals);
        }

        private void button_UpdateHospital_Click(object sender, EventArgs e)
        {
            UpdateHospitalcontrol oControl = new UpdateHospitalcontrol();
            MainControl.showControl(oControl, panel_ManageHospitals);
        }
        public async void GetAllHospitals()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://localhost:44310/api/hospitals/GetAllHospitals");
                    var response = await client.GetAsync(client.BaseAddress);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        List<Models.ModHospital> lstContent = JsonConvert.DeserializeObject<List<Models.ModHospital>>(content);

                        int i = 0;
                        string specialities; // Concatenate specialities as string to be shown in DataGridView

                        foreach (var hospital in lstContent)
                        {
                            dataGridView_Hospitals.Rows.Insert(i, hospital.Name, hospital.Address, hospital.ZipCode, hospital.City);
                            i++;
                        }

                        label_loading.Visible = false;
                        dataGridView_Hospitals.Visible = true;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
