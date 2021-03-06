using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.UserControls
{
    class MainControl
    {
        public static void showControl(Control control, Control panel)
        {
            panel.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            panel.BringToFront();
            control.Focus();

            panel.Controls.Add(control);
        }
    }
}
