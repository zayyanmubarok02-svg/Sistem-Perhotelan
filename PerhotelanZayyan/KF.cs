using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerhotelanZayyan
{
    class KF
    {
        public static void untukForm(Form FormApa, Panel panelApa)
        {
            panelApa.Controls.Clear();
            FormApa.FormBorderStyle = FormBorderStyle.None;
            FormApa.Dock = DockStyle.Fill;
            panelApa.Controls.Add(FormApa);
            FormApa.Visible = true;
        }
    }
}
