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

namespace HospiNetApp.UserControls.AdminDashboard.Patients
{
    public partial class UpdatePatientControl : UserControl
    {
        public Models.ModPatient UpdatedPatient = new Models.ModPatient();
        public UpdatePatientControl(Models.ModPatient oPatient)
        {
            InitializeComponent();
            this.UpdatedPatient.Id = oPatient.Id;
            UpdateVariables(oPatient.FirstName, oPatient.LastName, oPatient.Birthday);
        }

        public void UpdateVariables(string FirstName, string LastName, DateTime Birthday)
        {
            textBox_FirstName.Text = FirstName;
            textBox_LastName.Text = LastName;
            dateTimePicker_Birthday.Value = Birthday;
        }

        private async void button_UpdatePatient_Click(object sender, EventArgs e)
        {
            this.UpdatedPatient.FirstName = textBox_FirstName.Text;
            this.UpdatedPatient.LastName = textBox_LastName.Text;
            this.UpdatedPatient.Birthday = dateTimePicker_Birthday.Value;

            var content = JsonConvert.SerializeObject(this.UpdatedPatient);

            const string apiRequest = "https://localhost:44310/api/patients/Update";

            using (var client = new HttpClient())
            {
                var response = await client.PutAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));

                if (response.IsSuccessStatusCode)
                    label_Success.Visible = true;

                if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    label_Failed.Visible = true;
            }
        }
    }
}
