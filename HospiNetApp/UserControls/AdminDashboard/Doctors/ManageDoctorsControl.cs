using HospiNetApp.UserControls.AdminDashboard.Hospitals;
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

namespace HospiNetApp.UserControls.AdminDashboard.Doctors
{
    public partial class ManageDoctorsControl : UserControl
    {
        public ManageDoctorsControl()
        {
            InitializeComponent();
        }

        public async void GetAllDoctors()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://localhost:44310/api/doctors/GetAll");
                    var response = await client.GetAsync(client.BaseAddress);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        List<Models.ModDoctor> lstContent = JsonConvert.DeserializeObject<List<Models.ModDoctor>>(content);

                        int i = 0;
                        string specialities; // Concatenate specialities as string to be shown in DataGridView

                        foreach (var doctor in lstContent)
                        {
                            specialities = "";

                            foreach (var speciality in doctor.Specialities)
                            {
                                specialities += speciality.Name + ", ";
                            }

                            // Remove last space and comma from foreach loop
                            if (specialities != "")
                                specialities = specialities.Remove(specialities.Length - 2); 

                            dataGridView_ManageDoctors.Rows.Insert(i, doctor.Id, doctor.FirstName, doctor.LastName, specialities);
                            i++;
                        }

                        label_loading.Visible = false;
                        dataGridView_ManageDoctors.Visible = true;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private void button_AddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctorControl oControl = new AddDoctorControl();
            MainControl.showControl(oControl, panel_ManageDoctors);
        }
    }
}
