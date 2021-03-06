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
    public partial class DoctorDashboardForm : Form
    {
        private Guid? DoctorId;
        public DoctorDashboardForm(Guid? DoctorId)
        {
            InitializeComponent();
            this.DoctorId = DoctorId;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var showAppointments = new UserControls.DoctorDashboard.ShowAppointmentsControl(this.DoctorId);
            UserControls.MainControl.showControl(showAppointments, DoctorDashboardControlPanel);
        }

        private void button_doctorDashboard_ShowAppointments_Click(object sender, EventArgs e)
        {
            var oControl = new UserControls.DoctorDashboard.ShowAppointmentsControl(this.DoctorId);
            UserControls.MainControl.showControl(oControl, DoctorDashboardControlPanel);
        }

        private void label_appName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_doctorDashboard_ManageAttendances_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_doctor_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void DoctorDashboardControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
