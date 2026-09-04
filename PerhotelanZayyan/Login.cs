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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DB.crud($"SELECT * FROM users WHERE Username = '{TxtUser.Text}' && Password = MD5('{TxtPass.Text}')");
            int cekbaris = DB.ds.Tables[0].Rows.Count;
            if (cekbaris == 1)
            {
                DataRow baris = DB.ds.Tables[0].Rows[0];
                Dashboard Dashboard = new Dashboard();
                Dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            DB.crud("SELECT users.Id, users.Username, users.Nama, role.Nama_role FROM users JOIN role ON users.Id_role = role.Id_role WHERE Username = '" + TxtUser.Text + "' AND Password = '" + TxtPass.Text + "'");

            int baris = DB.ds.Tables[0].Rows.Count;

            if (baris == 1)
            {
                DataRow row = DB.ds.Tables[0].Rows[0];
                string roleUser = row["Nama_role"].ToString();

                if (roleUser == "admin")
                {
                    Dashboard Fa = new Dashboard();
                    Fa.Show();
                }
                else
                {
                    DataRow brs = DB.ds.Tables[0].Rows[0];
                    string id = "" + brs["Id"];

                    Dashboardresep F1 = new Dashboardresep();
                    F1.IDLogin = id;
                    F1.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("salah");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
