using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.Forms.Utilities
{
    static class WindowDragging
    {
        public static void MouseDown(Form form, ref bool dragging, ref Point dragCursorPoint, ref Point dragFormPoint)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = form.Location;
        }

        public static void MouseMove(Form form, ref bool dragging, ref Point dragCursorPoint, ref Point dragFormPoint)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                form.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        public static void MouseUp(ref bool dragging)
        {
            dragging = false;
        }
    }
}
