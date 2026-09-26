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
    public partial class Fpembayaran : Form
    {
        public Fpembayaran()
        {
            InitializeComponent();
        }
        public void isiBooking()
        {
            CmbBook.Items.Clear(); // Ganti CmbBooking sesuai nama ComboBox BookingId kamu
            DB.crud("SELECT Kode_booking FROM booking");
            foreach (DataRow brs in DB.ds.Tables[0].Rows)
            {
                CmbBook.Items.Add(brs["Kode_booking"].ToString());
            }
        }

        // Event saat Kode Booking dipilih oleh resepsionis
        private void CmbBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBook.Text != "")
            {
                string kode = CmbBook.Text;
                // Ambil Total_biaya dari tabel booking
                DB.crud($"SELECT Total_biaya FROM booking WHERE Kode_booking = '{kode}'");
                if (DB.ds.Tables[0].Rows.Count > 0)
                {
                    txtjumlah.Text = DB.ds.Tables[0].Rows[0]["Total_biaya"].ToString();
                }
            }
        }
        public void bersih()
        {
            txtjumlah.Clear();
            CmbBook.SelectedIndex = -1;
            CmbMetode.SelectedIndex = -1;
            CmbStatus.SelectedIndex = -1;
            labelId.Text = "";
        }

        // 1. Fungsi muat Kode Booking
        public void isiBook()
        {
            CmbBook.Items.Clear();
            DB.crud("SELECT Kode_booking FROM booking");
            foreach (DataRow brs in DB.ds.Tables[0].Rows)
            {
                CmbBook.Items.Add(brs["Kode_booking"].ToString());
            }
        }

        // 2. Fungsi muat Metode Pembayaran
        public void isiMetode()
        {
            CmbMetode.Items.Clear();
            CmbMetode.Items.Add("cash");
            CmbMetode.Items.Add("transfer");
            CmbMetode.Items.Add("qris");
        }

        // 3. Fungsi muat Status Pembayaran
        public void isiStatus()
        {
            CmbStatus.Items.Clear();
            CmbStatus.Items.Add("DP");
            CmbStatus.Items.Add("Lunas");
        }
        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            // JOIN ke tabel booking untuk mengambil Kode_booking
            DB.crud("SELECT pembayaran.Id, booking.Kode_booking, pembayaran.Tanggal_bayar, pembayaran.Jumlah_bayar, pembayaran.Metode, pembayaran.Status FROM pembayaran JOIN booking ON pembayaran.Booking_id = booking.Id");

            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string kode = "" + Row["Kode_booking"];
                string tgl = "" + Row["Tanggal_bayar"];
                string jumlah = "" + Row["Jumlah_bayar"];
                string metode = "" + Row["Metode"];
                string status = "" + Row["Status"];

                guna2DataGridView1.Rows.Add(id, kode, tgl, jumlah, metode, status);
            }
        }

        // Otomatis memuat data ComboBox saat Form pertama kali dibuka
        private void Fpembayaran_Load(object sender, EventArgs e)
        {
            tampildata();
            isiBook();
            isiMetode();
            isiStatus();
        }
        private void CmbBook_DropDown(object sender, EventArgs e)
        {
            isiBook();
        }

        private void CmbMetode_DropDown(object sender, EventArgs e)
        {
            isiMetode();
        }

        private void CmbStatus_DropDown(object sender, EventArgs e)
        {
            isiStatus();
        }

        private void btnsimpan_Click_1(object sender, EventArgs e)
        {
            if (CmbBook.Text == "" || txtjumlah.Text == "" || CmbMetode.SelectedIndex == -1 || CmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Masukan Data Yang Lengkap ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string kodebooking = CmbBook.Text;
                string jumlah = txtjumlah.Text;
                string metode = CmbMetode.Text;
                string status = CmbStatus.Text;
                string tanggal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                DB.crud($"SELECT Id FROM booking WHERE Kode_booking = '{kodebooking}'");
                string idBooking = DB.ds.Tables[0].Rows[0]["Id"].ToString();

                DB.crud($"INSERT INTO pembayaran (Booking_id, Tanggal_bayar, Jumlah_bayar, Metode, Status) VALUES ('{idBooking}', '{tanggal}', '{jumlah}', '{metode}', '{status}')");

                bersih();
                tampildata();
            }
        }

        private void btntambah_Click_1(object sender, EventArgs e)
        {
            if (labelId.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu!");
                return;
            }

            string kodebooking = CmbBook.Text;
            string jumlah = txtjumlah.Text;
            string metode = CmbMetode.Text;
            string status = CmbStatus.Text;

            DB.crud($"SELECT Id FROM booking WHERE Kode_booking = '{kodebooking}'");
            string idBooking = DB.ds.Tables[0].Rows[0]["Id"].ToString();

            DB.crud($"UPDATE pembayaran SET Booking_id = '{idBooking}', Jumlah_bayar = '{jumlah}', Metode = '{metode}', Status = '{status}' WHERE Id = '{labelId.Text}'");

            tampildata();
            bersih();
            labelId.Text = "";
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (baris < 0) return;

            if (kolom == 6)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT pembayaran.Id, booking.Kode_booking, pembayaran.Jumlah_bayar, pembayaran.Metode, pembayaran.Status FROM pembayaran JOIN booking ON pembayaran.Booking_id = booking.Id WHERE pembayaran.Id = '{idbar}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    labelId.Text = "" + brs["Id"];
                    CmbBook.Text = "" + brs["Kode_booking"];
                    txtjumlah.Text = "" + brs["Jumlah_bayar"];
                    CmbMetode.Text = "" + brs["Metode"];
                    CmbStatus.Text = "" + brs["Status"];
                }
            }

            if (kolom == 7)
            {
                string idbar = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah Mau Hapus ID " + idbar + "?", "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM pembayaran WHERE Id = '{idbar}' ");
                }

                tampildata();
                bersih();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void CmbBook_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CmbBook.Text != "")
            {
                DB.crud($"SELECT Total_biaya FROM booking WHERE Kode_booking = '{CmbBook.Text}'");
                if (DB.ds.Tables[0].Rows.Count > 0)
                {
                    txtjumlah.Text = DB.ds.Tables[0].Rows[0]["Total_biaya"].ToString();
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                CmbBook.Text = row.Cells[1].Value.ToString();
                txtjumlah.Text = row.Cells[3].Value.ToString();
                CmbMetode.Text = row.Cells[4].Value.ToString();
                CmbStatus.Text = row.Cells[5].Value.ToString();
            }
        }

        private void txtjumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            // JOIN ke tabel booking untuk mengambil Kode_booking
            DB.crud($"SELECT pembayaran.Id, booking.Kode_booking, pembayaran.Tanggal_bayar, pembayaran.Jumlah_bayar, pembayaran.Metode, pembayaran.Status FROM pembayaran JOIN booking ON pembayaran.Booking_id = booking.Id where Kode_booking like '%{guna2TextBox1.Text}%'");

            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id"];
                string kode = "" + Row["Kode_booking"];
                string tgl = "" + Row["Tanggal_bayar"];
                string jumlah = "" + Row["Jumlah_bayar"];
                string metode = "" + Row["Metode"];
                string status = "" + Row["Status"];

                guna2DataGridView1.Rows.Add(id, kode, tgl, jumlah, metode, status);
            }
        }
    }
}