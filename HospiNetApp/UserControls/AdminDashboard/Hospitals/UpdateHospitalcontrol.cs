using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
{
    public partial class UpdateHospitalControl : UserControl
    {
        public UpdateHospitalControl(string name, string address, string zipCode, string city)
        {
            InitializeComponent();
            UpdateVariables(name, address, zipCode, city);
        }

        public void UpdateVariables(string name, string address, string zipCode, string city)
        {
            textBox_Name.Text = name;
            textBox_Address.Text = address;
            textBox_ZipCode.Text = zipCode;
            textBox_City.Text = city;
        }

        private void button_UpdateHospital_Click(object sender, EventArgs e)
        {
            
        }
    }
}
