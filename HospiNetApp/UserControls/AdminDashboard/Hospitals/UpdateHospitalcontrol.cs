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
    public partial class UpdateHospitalControl : UserControl
    {
        public Models.ModHospital updatedHospital;
        public UpdateHospitalControl(Models.ModHospital oHospital)
        {
            InitializeComponent();
            this.updatedHospital = new Models.ModHospital();
            this.updatedHospital.Id = oHospital.Id;
            UpdateVariables(oHospital);
        }

        public void UpdateVariables(Models.ModHospital oHospital)
        {
            textBox_Name.Text = oHospital.Name;
            textBox_Address.Text = oHospital.Address;
            textBox_ZipCode.Text = oHospital.ZipCode;
            textBox_City.Text = oHospital.City;
        }

        private async void button_UpdateHospital_Click(object sender, EventArgs e)
        {
            this.updatedHospital.Name = textBox_Name.Text;
            this.updatedHospital.Address = textBox_Address.Text;
            this.updatedHospital.ZipCode = textBox_ZipCode.Text;
            this.updatedHospital.City = textBox_City.Text;

            var content = JsonConvert.SerializeObject(this.updatedHospital);

            const string apiRequest = "https://localhost:44310/api/hospital/Update";

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
