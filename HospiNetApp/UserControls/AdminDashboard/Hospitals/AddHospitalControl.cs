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
    public partial class AddHospitalControl : UserControl
    {
        public AddHospitalControl()
        {
            InitializeComponent();
        }

        private async void button_AddHospital_Click(object sender, EventArgs e)
        {
            Models.ModHospital oHospital = new Models.ModHospital();

            oHospital.Name = textBox_Name.Text;
            oHospital.Address = textBox_Address.Text;
            oHospital.ZipCode = textBox_ZipCode.Text;
            oHospital.City = textBox_City.Text;

            var content = JsonConvert.SerializeObject(oHospital);

            const string apiRequest = "https://localhost:44310/api/hospitals/Add";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        label_Success.Visible = true;
                    }
                    else
                    {
                        label_Failed.Visible = true;
                    }
                }
            }
            catch (HttpRequestException exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
    }
}
