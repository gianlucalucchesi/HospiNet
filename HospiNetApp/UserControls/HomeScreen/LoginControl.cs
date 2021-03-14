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
    public partial class Login : UserControl
    {
        private Form HomeScreenForm;
        public Guid? DoctorId;
        public Guid? AdminId;
        public Login(Form form)
        {
            InitializeComponent();
            this.HomeScreenForm = form;
        }

        private async void button_loginScreen_login_Click(object sender, EventArgs e)
        {
            var firstName = textBox_loginScreen_FirstName.Text;
            var lastName = textBox_loginScreen_LastName.Text;

            label_loading.Visible = true;
            label_UnknownUser.Visible = false;

            if (Forms.HomeScreen.admin == true)
            {
                this.AdminId = await UserExists(firstName, lastName, "Admin");

                if (AdminId != null)
                {
                    AdminDashboardForm oAdminDashboardForm = new AdminDashboardForm();
                    oAdminDashboardForm.Show();
                    this.HomeScreenForm.Hide();
                } else
                {
                    label_loading.Visible = false;
                    label_UnknownUser.Visible = true;
                }
            }
            else if (Forms.HomeScreen.doctor == true)
            {
                this.DoctorId = await UserExists(firstName, lastName, "Doctor");

                if ( this.DoctorId != null)
                {
                    Forms.DoctorDashboardForm oDoctorDashboardForm = new Forms.DoctorDashboardForm(this.DoctorId, lastName);
                    oDoctorDashboardForm.Show();
                    this.HomeScreenForm.Hide();
                } else
                {
                    label_loading.Visible = false;
                    label_UnknownUser.Visible = true;
                }
            }
            else if (Forms.HomeScreen.patient == true)
            {
                Forms.PatientDashboardForm oPatientDashboardFrom = new Forms.PatientDashboardForm();
                oPatientDashboardFrom.Show();
                this.HomeScreenForm.Hide();
            }
        }

        private async Task<Guid?> UserExists(string Firstname, string LastName, string Type)
        {
            Guid? UserId = null;
            const string apiRequest = "https://localhost:44310/api/hospitals/UserExists";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiRequest}/?FirstName={Firstname}&LastName={LastName}&Type={Type}");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        if (content != "null")
                        {
                            UserId = JsonConvert.DeserializeObject<Guid>(content);
                        } 
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return UserId;
        }

        // https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-create-a-password-text-box-with-the-windows-forms-textbox-control?view=netframeworkdesktop-4.8
        private void Login_Load(object sender, EventArgs e)
        {
            textBox_loginScreen_FirstName.PasswordChar = '*';
            textBox_loginScreen_LastName.PasswordChar = '*';
        }
    }
}
