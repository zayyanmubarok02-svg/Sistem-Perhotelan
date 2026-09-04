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
    public partial class FTipeKamar : Form
    {
        public FTipeKamar()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtNmTipe.Text = "";
            txtHarga.Text = "";
            txtKapasitas.Text = "";
            txtDeskripsi.Text = "";
            label4.Text = "";
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT Id, Nama_tipe, Harga_permalam, Kapasitas, Deskripsi FROM tipe_kamar");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string nama = "" + Row["Nama_tipe"];
                string harga = "" + Row["Harga_permalam"];
                string kapasitas = "" + Row["Kapasitas"];
                string deskripsi = "" + Row["Deskripsi"];
                guna2DataGridView1.Rows.Add(id, nama, harga, kapasitas, deskripsi);
            }
        }

        private void FTipeKamar_Load(object sender, EventArgs e)
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

        private void FTipeKamar_Load_1(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (txtNmTipe.Text == "" || txtHarga.Text == "")
            {
                DialogResult DataKosong = MessageBox.Show("Masukan Data Yang Lengkap ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nama = txtNmTipe.Text;
                string harga = txtHarga.Text;
                string kapasitas = txtKapasitas.Text;
                string deskripsi = txtDeskripsi.Text;

                DB.crud($"INSERT INTO tipe_kamar VALUES (NULL, '{nama}', '{harga}', '{kapasitas}', '{deskripsi}')");

                bersih();
                tampildata();
            }
        }

        private void btntambah_Click_1(object sender, EventArgs e)
        {
            string nama = txtNmTipe.Text;
            string harga = txtHarga.Text;
            string kapasitas = txtKapasitas.Text;
            string deskripsi = txtDeskripsi.Text;

            DB.crud($"UPDATE tipe_kamar SET Nama_tipe = '{nama}', Harga_permalam = '{harga}', Kapasitas = '{kapasitas}', Deskripsi = '{deskripsi}' WHERE Id = '{label4.Text}'");

            tampildata();
            bersih();
            label4.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (baris < 0) return;

            if (kolom == 5)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT Id, Nama_tipe, Harga_permalam, Kapasitas, Deskripsi FROM tipe_kamar WHERE Id = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    label4.Text = "" + brs["Id"];
                    txtNmTipe.Text = "" + brs["Nama_tipe"];
                    txtHarga.Text = "" + brs["Harga_permalam"];
                    txtKapasitas.Text = "" + brs["Kapasitas"];
                    txtDeskripsi.Text = "" + brs["Deskripsi"];
                }
            }

            if (kolom == 6)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM tipe_kamar WHERE Id = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }
    }
}