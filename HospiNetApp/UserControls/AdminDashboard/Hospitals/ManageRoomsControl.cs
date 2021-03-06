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
    public partial class ManageRoomsControl : UserControl
    {
        public ManageRoomsControl()
        {
            InitializeComponent();
        }

        private void button_AddRoom_Click(object sender, EventArgs e)
        {
            AddRoomControl oControl = new AddRoomControl();
            MainControl.showControl(oControl, panel_ManageRooms);
        }

        public async void GetRooms()
        {
            //Todo
        }
    }
}
