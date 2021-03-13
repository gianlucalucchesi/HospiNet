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
        Models.ModHospital oHospital;

        public ManageHospitalsControl()
        {
            InitializeComponent();
            oHospital = new Models.ModHospital();
        }

        private void button_AddHospital_Click(object sender, EventArgs e)
        {
            AddHospitalControl oControl = new AddHospitalControl();
            MainControl.showControl(oControl, panel_ManageHospitals);
        }

        private void button_UpdateHospital_Click(object sender, EventArgs e)
        {
            UpdateHospitalControl oControl = new UpdateHospitalControl(this.oHospital);
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

                        foreach (var hospital in lstContent)
                        {
                            dataGridView_Hospitals.Rows.Insert(i, hospital.Id, hospital.Name, hospital.Address, hospital.ZipCode, hospital.City);
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

        private void dataGridView_Hospitals_SelectionChanged(object sender, EventArgs e)
        {
            button_UpdateHospital.Enabled = true;

            foreach (DataGridViewRow row in dataGridView_Hospitals.SelectedRows)
            {
                Guid.TryParse(row.Cells[0].Value.ToString(), out Guid convertedId);
                this.oHospital.Id = convertedId;
                this.oHospital.Name = row.Cells[1].Value.ToString();
                this.oHospital.Address = row.Cells[2].Value.ToString();
                this.oHospital.ZipCode = row.Cells[3].Value.ToString();
                this.oHospital.City = row.Cells[4].Value.ToString();
            }
        }
    }
}
