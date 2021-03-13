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
using Newtonsoft.Json;

namespace HospiNetApp.UserControls
{
    public partial class AddPatientIControl : UserControl
    {
        public AddPatientIControl()
        {
            InitializeComponent();
        }

        private async void button_AddPatient_Add_Click(object sender, EventArgs e)
        {
            const string apiRequest = "https://localhost:44310/api/patients/Add";
            // Reset labels if user already tried before
            label_AddPatient_Success.Visible = false;
            label_AddPatient_Failed.Visible = false;

            Models.ModPatient oPatient = new Models.ModPatient();

            oPatient.FirstName = textBox_AddPatient_FirstName.Text;
            oPatient.LastName = textBox_AddPatient_LastName.Text;
            oPatient.Birthday = dateTimePicker_AddPatient_Birthday.Value;

            var content = JsonConvert.SerializeObject(oPatient);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));

                if (response.IsSuccessStatusCode)
                    label_AddPatient_Success.Visible = true;

                if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    label_AddPatient_Failed.Visible = true;
            }
        }

        private void AddPatientIControl_Load(object sender, EventArgs e)
        {
            button_AddPatient_Add.Enabled = true;
        }
    }
}
