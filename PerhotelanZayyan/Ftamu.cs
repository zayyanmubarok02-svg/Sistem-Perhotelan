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
    public partial class FTamu : Form
    {
        public FTamu()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtNamaTamu.Text = "";
            txtNoTelp.Text = "";
            txtAlamat.Text = "";
            label4.Text = "";
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT Id, Nama_tamu, No_telepon, Alamat FROM tamu");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string nama = "" + Row["Nama_tamu"];
                string telp = "" + Row["No_telepon"];
                string alamat = "" + Row["Alamat"];
                guna2DataGridView1.Rows.Add(id, nama, telp, alamat);
            }
        }

        private void FTamu_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
          
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FTamu_Load_1(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (txtNamaTamu.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show("Masukan Data Yang Lengkap ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nama = txtNamaTamu.Text;
                string telp = txtNoTelp.Text;
                string alamat = txtAlamat.Text;

                DB.crud($"INSERT INTO tamu (Nama_tamu, No_telepon, Alamat) VALUES ('{nama}', '{telp}', '{alamat}')");

                bersih();
                tampildata();
            }
        }

        private void btntambah_Click_1(object sender, EventArgs e)
        {
            if (label4.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin diubah dari tabel terlebih dahulu!");
                return;
            }

            string nama = txtNamaTamu.Text;
            string telp = txtNoTelp.Text;
            string alamat = txtAlamat.Text;

            DB.crud($"UPDATE tamu SET Nama_tamu = '{nama}', No_telepon = '{telp}', Alamat = '{alamat}' WHERE Id = '{label4.Text}'");

            tampildata();
            bersih();
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (baris < 0) return;

            if (kolom == 4)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT Id, Nama_tamu, No_telepon, Alamat FROM tamu WHERE Id = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    label4.Text = "" + brs["Id"];
                    txtNamaTamu.Text = "" + brs["Nama_tamu"];
                    txtNoTelp.Text = "" + brs["No_telepon"];
                    txtAlamat.Text = "" + brs["Alamat"];
                }
            }
            if (kolom == 5)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus ID " + idbar + "?", "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM tamu WHERE Id = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampildata();
        }
    }
}