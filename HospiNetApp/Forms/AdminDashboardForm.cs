using HospiNetApp.UserControls;
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

namespace HospiNetApp
{
    public partial class AdminDashboardForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        // https://stackoverflow.com/questions/1241812/how-to-move-a-windows-form-when-its-formborderstyle-property-is-set-to-none
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Forms.Utilities.WindowDragging.MouseDown(this, ref dragging, ref dragCursorPoint, ref dragFormPoint);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Forms.Utilities.WindowDragging.MouseMove(this, ref dragging, ref dragCursorPoint, ref dragFormPoint);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Forms.Utilities.WindowDragging.MouseUp(ref dragging);
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

        private void button_managePatients_Click(object sender, EventArgs e)
        {
            HomePatientsControl oControl = new HomePatientsControl();
            MainControl.showControl(oControl, AdminDashboardControlPanel);
            oControl.GetAllPatients();
        }

        private void button_ManageDoctors_Click(object sender, EventArgs e)
        {
            UserControls.AdminDashboard.Doctors.ManageDoctorsControl oControl = new UserControls.AdminDashboard.Doctors.ManageDoctorsControl();
            MainControl.showControl(oControl, AdminDashboardControlPanel);
            oControl.GetAllDoctors();
        }

        private void button_ManageRooms_Click(object sender, EventArgs e)
        {
            UserControls.AdminDashboard.Hospitals.ManageRoomsControl oControl = new UserControls.AdminDashboard.Hospitals.ManageRoomsControl();
            MainControl.showControl(oControl, AdminDashboardControlPanel);
            oControl.GetRooms();
        }

        private void button_ManageHospitals_Click(object sender, EventArgs e)
        {
            UserControls.AdminDashboard.Hospitals.ManageHospitalsControl oControl = new UserControls.AdminDashboard.Hospitals.ManageHospitalsControl();
            MainControl.showControl(oControl, AdminDashboardControlPanel);
            oControl.GetAllHospitals();
        }
    }
}
