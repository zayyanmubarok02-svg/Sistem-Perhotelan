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
    public partial class FKamar : Form
    {
        public FKamar()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtnkamar.Text = "";
            CmbTKamar.SelectedIndex = -1;
            CmbStatus.SelectedIndex = -1;
            label4.Text = "";
        }

        public void isicbTipe()
        {
            CmbTKamar.Items.Clear();
            DB.crud("SELECT Nama_tipe FROM tipe_kamar");
            foreach (DataRow brs in DB.ds.Tables[0].Rows)
            {
                CmbTKamar.Items.Add(brs["Nama_tipe"].ToString());
            }
        }

        public void isiStatus()
        {
            CmbStatus.Items.Clear();
            CmbStatus.Items.Add("tersedia");
            CmbStatus.Items.Add("terisi");
            CmbStatus.Items.Add("maintenance");
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT kamar.Id, kamar.Nomor_kamar, tipe_kamar.Nama_tipe, kamar.Status FROM kamar JOIN tipe_kamar ON kamar.Tipe_kamar = tipe_kamar.Id");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string nomor = "" + Row["Nomor_kamar"];
                string tipe = "" + Row["Nama_tipe"];
                string status = "" + Row["Status"];
                guna2DataGridView1.Rows.Add(id, nomor, tipe, status);
            }
        }
        private void CmbTKamar_DropDown(object sender, EventArgs e)
        {
            isicbTipe();
        }

        private void CmbStatus_DropDown(object sender, EventArgs e)
        {
            isiStatus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampildata();
            isicbTipe();
            isiStatus();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnkamar.Text) || string.IsNullOrEmpty(CmbTKamar.Text) || CmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Masukkan Data Yang Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nomor = txtnkamar.Text;
            string tipe = CmbTKamar.Text;
            string status = CmbStatus.Text;

            DB.crud($"SELECT Id FROM tipe_kamar WHERE Nama_tipe = '{tipe}'");
            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                string idTipe = DB.ds.Tables[0].Rows[0]["Id"].ToString();
                DB.crud($"INSERT INTO kamar (Nomor_kamar, Tipe_kamar, Status) VALUES ('{nomor}', '{idTipe}', '{status}')");

                MessageBox.Show("Data Kamar Berhasil Disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bersih();
                tampildata();
            }
            else
            {
                MessageBox.Show("Tipe kamar tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntambah_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label4.Text))
            {
                MessageBox.Show("Pilih data yang ingin diubah dari tabel terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomor = txtnkamar.Text;
            string tipe = CmbTKamar.Text;
            string status = CmbStatus.Text;

            DB.crud($"SELECT Id FROM tipe_kamar WHERE Nama_tipe = '{tipe}'");
            if (DB.ds.Tables[0].Rows.Count > 0)
            {
                string idTipe = DB.ds.Tables[0].Rows[0]["Id"].ToString();
                DB.crud($"UPDATE kamar SET Nomor_kamar = '{nomor}', Tipe_kamar = '{idTipe}', Status = '{status}' WHERE Id = '{label4.Text}'");

                MessageBox.Show("Data Kamar Berhasil Diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tampildata();
                bersih();
            }
        }

        private void FKamar_Load_1(object sender, EventArgs e)
        {
            tampildata();
            isicbTipe();
            isiStatus();
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Cek agar tidak error saat header diklik
            if (e.RowIndex >= 0)
            {
                // 2. Ambil baris yang sedang diklik
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                // 3. Masukkan nilai dari sel DataGridView ke TextBox / ComboBox
                // Catatan: Ganti "Username", "Nama", dll. sesuai nama kolom di database/tabel kamu

                // Simpan ID ke label/variabel penampung (penting untuk query UPDATE)
                labelId.Text = row.Cells[0].Value.ToString();

                txtnkamar.Text = row.Cells[1].Value.ToString();
                CmbTKamar.Text = row.Cells[2].Value.ToString();
                CmbStatus.Text = row.Cells[3].Value.ToString();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud($"SELECT kamar.Id, kamar.Nomor_kamar, tipe_kamar.Nama_tipe, kamar.Status FROM kamar JOIN tipe_kamar ON kamar.Tipe_kamar = tipe_kamar.Id where Nomor_kamar like '%{guna2TextBox1.Text}%'");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string nomor = "" + Row["Nomor_kamar"];
                string tipe = "" + Row["Nama_tipe"];
                string status = "" + Row["Status"];
                guna2DataGridView1.Rows.Add(id, nomor, tipe, status);
            }
        }
    }
}
