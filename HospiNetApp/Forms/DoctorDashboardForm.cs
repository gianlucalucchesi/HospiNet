﻿using System;
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
        private string LastName;

        public DoctorDashboardForm(Guid? DoctorId, string LastName)
        {
            InitializeComponent();
            this.DoctorId = DoctorId;
            label_hello.Text = "Hello Dr. " + LastName + ".";
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

        private void button_doctorDashboard_ShowAppointments_Click(object sender, EventArgs e)
        {
            var oControl = new UserControls.DoctorDashboard.ManageAppointmentsControl(this.DoctorId);
            UserControls.MainControl.showControl(oControl, DoctorDashboardControlPanel);
        }

        private void button_doctorDashboard_ManageAttendances_Click(object sender, EventArgs e)
        {
            var oControl = new UserControls.DoctorDashboard.ManageAttendancesControl(this.DoctorId);
            UserControls.MainControl.showControl(oControl, DoctorDashboardControlPanel);
        }

        private void DoctorDashboardForm_Load(object sender, EventArgs e)
        {
            label_hello.Text = "Hello Dr. " + LastName + ".";
        }
    }
}
