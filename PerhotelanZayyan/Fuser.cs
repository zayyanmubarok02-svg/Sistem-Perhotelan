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
    public partial class Fuser : Form
    {
        public Fuser()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtuser.Clear();
            txtpass.Clear();
            txtnama.Clear();
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT users.Id, users.Username, users.Password, users.Nama, role.Nama_role FROM users JOIN role ON users.Id_role = role.Id_role");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string username = "" + Row["Username"];
                string password = "" + Row["Password"];
                string nama = "" + Row["Nama"];
                string role = "" + Row["Nama_role"];
                guna2DataGridView1.Rows.Add(id, username, password, nama, role);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "" || txtnama.Text == "" || CmbRol.SelectedIndex == -1)
            {
                DialogResult DataKosong = MessageBox.Show("Masukan Data Yang Lengkap ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string user = txtuser.Text;
                string pass = txtpass.Text;
                string nama = txtnama.Text;
                string role = CmbRol.Text;

                DB.crud($"SELECT Id_role FROM role WHERE Nama_role = '{role}'");
                string idRole = DB.ds.Tables[0].Rows[0]["Id_role"].ToString();

                DB.crud($"INSERT INTO users VALUES (NULL, '{user}', '{pass}', '{nama}', '{idRole}', 'Aktif')");
                bersih();
                tampildata();
            }
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            string role = CmbRol.Text;
            DB.crud($"SELECT Id_role FROM role WHERE Nama_role = '{role}'");
            string idRole = DB.ds.Tables[0].Rows[0]["Id_role"].ToString();

            DB.crud($"UPDATE users SET Username = '{txtuser.Text}', Password = '{txtpass.Text}', Nama = '{txtnama.Text}', Id_role = '{idRole}' WHERE Id = '{label4.Text}'");

            tampildata();
            bersih();
            label4.Text = "";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (kolom == 5)
            {

                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT users.Id, users.Username, users.Password, users.Nama, role.Nama_role FROM users JOIN role ON users.Id_role = role.Id_role WHERE users.Id = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string idr = "" + brs["Id"];
                    string user = "" + brs["Username"];
                    string pass = "" + brs["Password"];
                    string nama = "" + brs["Nama"];
                    string role = "" + brs["Nama_role"];
                    label4.Text = idr;
                    txtnama.Text = nama;
                    txtuser.Text = user;
                    txtpass.Text = pass;
                    CmbRol.Text = role;
                }

            }

            if (kolom == 6)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM users WHERE Id = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void Fuser_Load(object sender, EventArgs e)
        {

        }

        private void CmbRol_DropDown(object sender, EventArgs e)
        {
            CmbRol.Items.Clear();
            CmbRol.Items.Add("admin");
            CmbRol.Items.Add("resepsionis");
        }
    }
}