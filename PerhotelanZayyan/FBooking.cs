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
    public partial class Fbooking : Form
    {
        public Fbooking()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            CmbTamu.SelectedIndex = -1;
            CmbKamar.SelectedIndex = -1;
            CmbStatus.SelectedIndex = -1;
            txttotal.Text = "";
            txtkode.Text = "";
            label4.Text = "";
        }

        public void isiTamu()
        {
            CmbTamu.Items.Clear();
            DB.crud("SELECT Nama_tamu FROM tamu");
            foreach (DataRow brs in DB.ds.Tables[0].Rows)
            {
                CmbTamu.Items.Add(brs["Nama_tamu"].ToString());
            }
        }

        public void isiKamar()
        {
            CmbKamar.Items.Clear();
            // PERBAIKAN: Menggunakan LOWER() agar tetap membaca status 'Tersedia' maupun 'tersedia'
            DB.crud("SELECT Nomor_kamar FROM kamar WHERE LOWER(Status) = 'tersedia'");
            foreach (DataRow brs in DB.ds.Tables[0].Rows)
            {
                CmbKamar.Items.Add(brs["Nomor_kamar"].ToString());
            }
        }

        public void isiStatus()
        {
            CmbStatus.Items.Clear();
            CmbStatus.Items.Add("checkin");
            CmbStatus.Items.Add("checkout");
            CmbStatus.Items.Add("batal");
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DB.crud("SELECT booking.Id, booking.Kode_booking, tamu.Nama_tamu, kamar.Nomor_kamar, booking.Tgl_checkin, booking.Tgl_checkout, booking.Total_biaya, booking.Status_transaksi FROM booking JOIN tamu ON booking.Tamu_id = tamu.Id JOIN kamar ON booking.Kamar_id = kamar.Id");
            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string kode = "" + Row["Kode_booking"];
                string namatamu = "" + Row["Nama_tamu"];
                string nomorkamar = "" + Row["Nomor_kamar"];
                string checkin = "" + Row["Tgl_checkin"];
                string checkout = "" + Row["Tgl_checkout"];
                string total = "" + Row["Total_biaya"];
                string status = "" + Row["Status_transaksi"];
                guna2DataGridView1.Rows.Add(id, kode, namatamu, nomorkamar, checkin, checkout, total, status);
            }
        }

        public void hitungtotal()
        {
            if (CmbKamar.Text != "")
            {
                string nomorkamar = CmbKamar.Text;
                DB.crud($"SELECT tipe_kamar.Harga_permalam FROM kamar JOIN tipe_kamar ON kamar.Tipe_kamar = tipe_kamar.Id WHERE kamar.Nomor_kamar = '{nomorkamar}'");

                if (DB.ds.Tables[0].Rows.Count > 0)
                {
                    decimal harga = Convert.ToDecimal(DB.ds.Tables[0].Rows[0]["Harga_permalam"]);
                    int jumlahmalam = (dtpCheckout.Value.Date - dtpCheckin.Value.Date).Days;
                    if (jumlahmalam < 1) jumlahmalam = 1;

                    decimal total = harga * jumlahmalam;
                    txttotal.Text = total.ToString();
                }
            }
        }

        private void Fbooking_Load(object sender, EventArgs e)
        {
            tampildata();
            isiTamu();
            isiKamar();
            isiStatus();
        }

        private void Fbooking_Load_1(object sender, EventArgs e)
        {
            tampildata();
            isiTamu();
            isiKamar();
            isiStatus();
        }

        private void CmbTamu_DropDown(object sender, EventArgs e)
        {
            isiTamu();
        }

        private void CmbKamar_DropDown(object sender, EventArgs e)
        {
            isiKamar();
        }

        private void CmbStatus_DropDown(object sender, EventArgs e)
        {
            isiStatus();
        }

        private void CmbKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            hitungtotal();
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            hitungtotal();
        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {
            hitungtotal();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampildata();
            isiTamu();
            isiKamar();
        }

        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (CmbTamu.Text == "" || CmbKamar.Text == "" || CmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Masukan Data Yang Lengkap ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string namatamu = CmbTamu.Text;
                string nomorkamar = CmbKamar.Text;
                string checkin = dtpCheckin.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string checkout = dtpCheckout.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string total = txttotal.Text;
                string status = CmbStatus.Text;
                string kode = txtkode.Text;
                string iduser = "1";

                DB.crud($"SELECT Id FROM tamu WHERE Nama_tamu = '{namatamu}'");
                string idTamu = DB.ds.Tables[0].Rows[0]["Id"].ToString();

                DB.crud($"SELECT Id FROM kamar WHERE Nomor_kamar = '{nomorkamar}'");
                string idKamar = DB.ds.Tables[0].Rows[0]["Id"].ToString();

                DB.crud($"INSERT INTO booking VALUES (NULL, '{kode}', '{idTamu}', '{idKamar}', '{iduser}', '{checkin}', '{checkout}', '{total}', '{status}')");

                DB.crud($"UPDATE kamar SET Status = 'terisi' WHERE Id = '{idKamar}'");

                bersih();
                tampildata();
                isiKamar();
            }
        }

        private void btntambah_Click_1(object sender, EventArgs e)
        {
            string namatamu = CmbTamu.Text;
            string nomorkamar = CmbKamar.Text;
            string checkin = dtpCheckin.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string checkout = dtpCheckout.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string total = txttotal.Text;
            string status = CmbStatus.Text;

            DB.crud($"SELECT Id FROM tamu WHERE Nama_tamu = '{namatamu}'");
            string idTamu = DB.ds.Tables[0].Rows[0]["Id"].ToString();

            DB.crud($"SELECT Id FROM kamar WHERE Nomor_kamar = '{nomorkamar}'");
            string idKamar = DB.ds.Tables[0].Rows[0]["Id"].ToString();

            DB.crud($"UPDATE booking SET Tamu_id = '{idTamu}', Kamar_id = '{idKamar}', Tgl_checkin = '{checkin}', Tgl_checkout = '{checkout}', Total_biaya = '{total}', Status_transaksi = '{status}' WHERE Id = '{label4.Text}'");

            if (status == "checkout" || status == "batal")
            {
                DB.crud($"UPDATE kamar SET Status = 'tersedia' WHERE Id = '{idKamar}'");
            }

            tampildata();
            bersih();
            isiKamar();
            label4.Text = "";
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (baris < 0) return;

            if (kolom == 8)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT booking.Id, booking.Kode_booking, tamu.Nama_tamu, kamar.Nomor_kamar, booking.Tgl_checkin, booking.Tgl_checkout, booking.Total_biaya, booking.Status_transaksi FROM booking JOIN tamu ON booking.Tamu_id = tamu.Id JOIN kamar ON booking.Kamar_id = kamar.Id WHERE booking.Id = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    label4.Text = "" + brs["Id"];
                    txtkode.Text = "" + brs["Kode_booking"];
                    CmbTamu.Text = "" + brs["Nama_tamu"];
                    CmbKamar.Text = "" + brs["Nomor_kamar"];
                    dtpCheckin.Value = Convert.ToDateTime(brs["Tgl_checkin"]);
                    dtpCheckout.Value = Convert.ToDateTime(brs["Tgl_checkout"]);
                    txttotal.Text = "" + brs["Total_biaya"];
                    CmbStatus.Text = "" + brs["Status_transaksi"];
                }
            }

            if (kolom == 9)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus?" + idbar, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM booking WHERE Id = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }
    }
}