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
    public partial class FRole : Form
    {
        public FRole()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            TxtnNmrol.Clear();
            TxtKet.Clear();
            label1.Text = "";
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();

            DB.crud("SELECT * FROM role");

            foreach (DataRow Row in DB.ds.Tables[0].Rows)
            {
                string id = "" + Row["Id_role"];
                string nm = "" + Row["Nama_role"];
                string ket = "" + Row["Keterangan"];

                guna2DataGridView1.Rows.Add(id, nm, ket);
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (TxtnNmrol.Text == "" || TxtKet.Text == "")
            {
                MessageBox.Show(
                    "Masukan Data Yang Lengkap!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            string nama = TxtnNmrol.Text;
            string ket = TxtKet.Text;

            DB.crud(
                $"INSERT INTO role (Nama_role, Keterangan) VALUES ('{nama}', '{ket}')"
            );

            MessageBox.Show(
                "Data berhasil disimpan!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            bersih();
            tampildata();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;

            if (kolom == 3)
            {
                string idrole = guna2DataGridView1
                    .Rows[baris]
                    .Cells[0]
                    .Value
                    .ToString();

                DB.crud(
                    $"SELECT * FROM role WHERE Id_role = '{idrole}'"
                );

                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string id = "" + brs["Id_role"];
                    string nmrol = "" + brs["Nama_role"];
                    string ket = "" + brs["Keterangan"];

                    label1.Text = id;
                    TxtnNmrol.Text = nmrol;
                    TxtKet.Text = ket;
                }
            }

            if (kolom == 4)
            {
                string idrole = guna2DataGridView1
                    .Rows[baris]
                    .Cells[0]
                    .Value
                    .ToString();

                DialogResult setuju = MessageBox.Show(
                    "Apakah Mau Hapus Data dengan ID " + idrole + "?",
                    "Pemberitahuan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (setuju == DialogResult.Yes)
                {
                    DB.crud(
                        $"DELETE FROM role WHERE Id_role = '{idrole}'"
                    );

                    MessageBox.Show(
                        "Data berhasil dihapus!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    tampildata();
                    bersih();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show(
                    "Silahkan pilih data yang ingin diubah terlebih dahulu!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            if (TxtnNmrol.Text == "" || TxtKet.Text == "")
            {
                MessageBox.Show(
                    "Masukan Data Yang Lengkap!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            DB.crud(
                $"UPDATE role SET " +
                $"Nama_role = '{TxtnNmrol.Text}', " +
                $"Keterangan = '{TxtKet.Text}' " +
                $"WHERE Id_role = '{label1.Text}'"
            );

            MessageBox.Show(
                "Data berhasil diupdate!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            tampildata();
            bersih();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampildata();
            bersih();
        }

        private void FRole_Load(object sender, EventArgs e)
        {

        }
    }
}