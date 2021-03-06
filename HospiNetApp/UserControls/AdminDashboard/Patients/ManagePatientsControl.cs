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

namespace HospiNetApp.UserControls
{
    public partial class HomePatientsControl : UserControl
    {
        private string FirstN { get; set; }
        private string LastN { get; set; }
        private DateTime Birthd { get; set; }

        public HomePatientsControl()
        {
            InitializeComponent();
        }

        public async void GetAllPatients()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://localhost:44310/api/patients/GetAll");
                    var response = await client.GetAsync(client.BaseAddress);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        List<Models.ModPatient> lstContent = JsonConvert.DeserializeObject<List<Models.ModPatient>>(content);

                        int i = 0;

                        foreach (var patient in lstContent)
                        {
                            dataGridView_homePatients.Rows.Insert(i, patient.FirstName, patient.LastName, patient.Birthday.ToShortDateString());
                            i++;
                        }

                        label_loading.Visible = false;
                        dataGridView_homePatients.Visible = true;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private void button_HomePatients_AddPatient_Click(object sender, EventArgs e)
        {
            AddPatientIControl oControl = new AddPatientIControl();
            MainControl.showControl(oControl, HomePatientsControlPanel);
        }

        private void button_HomePatients_UpdatePatient_Click(object sender, EventArgs e)
        {
            AdminDashboard.Patients.UpdatePatientControl oControl = new AdminDashboard.Patients.UpdatePatientControl(this.FirstN, this.LastN, this.Birthd);
            MainControl.showControl(oControl, HomePatientsControlPanel);
        }

        private void dataGridView_homePatients_SelectionChanged(object sender, EventArgs e)
        {
            button_HomePatients_UpdatePatient.Enabled = true;

            foreach (DataGridViewRow row in dataGridView_homePatients.SelectedRows)
            {
                this.FirstN = row.Cells[0].Value.ToString();
                this.LastN = row.Cells[1].Value.ToString();
                this.Birthd = DateTime.Parse(row.Cells[2].Value.ToString());
            }
        }
    }
}
