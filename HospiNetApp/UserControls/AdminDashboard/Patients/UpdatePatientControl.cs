using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.UserControls.AdminDashboard.Patients
{
    public partial class UpdatePatientControl : UserControl
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public UpdatePatientControl(string FirstName, string LastName, DateTime Birthday)
        {
            InitializeComponent();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            UpdateVariables();
        }

        public void UpdateVariables()
        {
            textBox_FirstName.Text = this.FirstName;
            textBox_LastName.Text = this.LastName;
            dateTimePicker_Birthday.Value = this.Birthday;
        }
    }
}
