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
    public partial class AddDoctorControl : UserControl
    {
        private List<Models.ModSpeciality> lstSpecialities;
        public AddDoctorControl()
        {
            InitializeComponent();
            lstSpecialities = new List<Models.ModSpeciality>();
        }

        private async void button_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (comboBox_Speciality.SelectedItem != null)
            {
                listBox_Specialities.Items.Add(comboBox_Speciality.SelectedItem);

                Models.ModSpeciality oSpeciality = await GetSpeciality(comboBox_Speciality.SelectedItem.ToString());
                lstSpecialities.Add(oSpeciality);
            }
        }

        private async Task<Models.ModSpeciality> GetSpeciality(string specialityName)
        {
            List<Models.ModSpeciality> lstSpecialities = await GetAllSpecialities();
            Models.ModSpeciality oSpeciality = lstSpecialities.Where(x => x.Name == specialityName).FirstOrDefault();

            return oSpeciality;
        }

        private async Task<List<Models.ModSpeciality>> GetAllSpecialities()
        {
            List<Models.ModSpeciality> lstContent = new List<Models.ModSpeciality>();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://localhost:44310/api/doctors/specialities");
                    var response = await client.GetAsync(client.BaseAddress);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        lstContent = JsonConvert.DeserializeObject<List<Models.ModSpeciality>>(content);
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

        private async void button_AddDoctor_Click(object sender, EventArgs e)
        {
            Models.ModDoctor oDoctor = new Models.ModDoctor();
            oDoctor.FirstName = textBox_FirstName.Text;
            oDoctor.LastName = textBox_LastName.Text;
            oDoctor.Specialities = this.lstSpecialities;

            var content = JsonConvert.SerializeObject(oDoctor);

            const string apiRequest = "https://localhost:44310/api/doctors/Add";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(new Uri(apiRequest), new StringContent(content, Encoding.Default, "application/json"));

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        label_Success.Visible = true;
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
