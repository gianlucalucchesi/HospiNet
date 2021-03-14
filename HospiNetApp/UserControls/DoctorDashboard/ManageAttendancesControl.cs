using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.UserControls.DoctorDashboard
{
    public partial class ManageAttendancesControl : UserControl
    {
        private Guid? DoctorId;

        public ManageAttendancesControl(Guid? DoctorId)
        {
            InitializeComponent();
            this.DoctorId = DoctorId;
        }
    }
}
