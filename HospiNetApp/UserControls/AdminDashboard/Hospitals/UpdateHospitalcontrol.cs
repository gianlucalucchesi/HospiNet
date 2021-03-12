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
    public partial class UpdateHospitalcontrol : UserControl
    {
        public string Name2;
        public string Address;
        public string ZipCode;
        public string City;

        public UpdateHospitalcontrol(string name, string address, string zipCode, string city)
        {
            InitializeComponent();
            this.Name2 = name;
            this.Address = address;
            this.ZipCode = zipCode;
            this.City = city;
            UpdateVariables();
        }

        public void UpdateVariables()
        {
            textBox_Name.Text = this.Name2;
            textBox_Address.Text = this.Address;
            textBox_ZipCode.Text = this.ZipCode;
            textBox_City.Text = this.City;
        }
    }
}
