using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerhotelanZayyan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (pnldrop.Visible == false)
            {
                pnldrop.Visible = true;
            }
            else
            {
                pnldrop.Visible = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fuser user = new Fuser()
            {
                TopLevel = false,
                TopMost = true
            };
            KF.untukForm(user, pnlcontent);
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void pnlcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnldrop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FRole role = new FRole()
            {
                TopLevel = false,
                TopMost = true
            };
            KF.untukForm(role, pnlcontent);
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FTamu tamu= new FTamu()
            {
                TopLevel = false,
                TopMost = true
            };
            KF.untukForm(tamu, pnlcontent);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FTipeKamar tipekamar = new FTipeKamar()
            {
                TopLevel = false,
                TopMost = true
            };
            KF.untukForm(tipekamar, pnlcontent);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FKamar kamar = new FKamar()
            {
                TopLevel = false,
                TopMost = true
            };
            KF.untukForm(kamar, pnlcontent);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Fpembayaran bayar = new Fpembayaran()
            {
                TopLevel = false,
                TopMost = true
            };
            KF.untukForm(bayar, pnlcontent);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Fbooking booking = new Fbooking()
            {
                TopLevel = false,
                TopMost = true
            };
            KF.untukForm(booking, pnlcontent);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
