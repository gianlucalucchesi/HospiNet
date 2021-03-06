using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.Forms
{
    public partial class PatientDashboardForm : Form
    {
        public PatientDashboardForm()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            string msg = "                         Close?";
            string title = "Close application";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(msg, title, buttons);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button_patientDashboard_NewAppointment_Click(object sender, EventArgs e)
        {
            var oControl = new UserControls.PatientDashboard.NewAppointmentControl();
            UserControls.MainControl.showControl(oControl, PatientDashboardControlPanel);
        }

        private void button_patientDashboard_ManageAppointments_Click(object sender, EventArgs e)
        {
            var oControl = new UserControls.PatientDashboard.ManageAppointmentControl();
            UserControls.MainControl.showControl(oControl, PatientDashboardControlPanel);
        }
    }
}
