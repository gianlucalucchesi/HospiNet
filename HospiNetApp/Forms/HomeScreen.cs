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
    public partial class HomeScreen : Form
    {
        public static bool admin = false;
        public static bool doctor = false;
        public static bool patient = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public HomeScreen()
        {
            InitializeComponent();
        }

        public void showLoginScreen()
        {
            UserControls.Login oControl = new UserControls.Login(this);
            UserControls.MainControl.showControl(oControl, panel_HomeScreen);
            pictureBox1.BringToFront();
        }

        private void button_homeScreen_Administration_Click(object sender, EventArgs e)
        {
            admin = true;
            doctor = false;
            patient = false;

            showLoginScreen();
        }

        private void button_homeScreen_Doctor_Click(object sender, EventArgs e)
        {
            doctor = true;
            admin = false;
            patient = false;

            showLoginScreen();
        }

        private void button_homeScreen_Patient_Click(object sender, EventArgs e)
        {
            patient = true;
            admin = false;
            doctor = false;

            var oForm = new Forms.PatientDashboardForm();
            this.Hide();  
            oForm.Show();
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

        private void HomeScreen_MouseDown(object sender, MouseEventArgs e)
        {
            Forms.Utilities.WindowDragging.MouseDown(this, ref dragging, ref dragCursorPoint, ref dragFormPoint);
        }

        private void HomeScreen_MouseMove(object sender, MouseEventArgs e)
        {
            Forms.Utilities.WindowDragging.MouseMove(this, ref dragging, ref dragCursorPoint, ref dragFormPoint);
        }

        private void HomeScreen_MouseUp(object sender, MouseEventArgs e)
        {
            Forms.Utilities.WindowDragging.MouseUp(ref dragging);
        }
    }
}
