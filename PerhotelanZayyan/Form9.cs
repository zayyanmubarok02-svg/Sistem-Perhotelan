using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace PerhotelanZayyan
{
    public partial class Form9 : Form
    {
        private ReportDocument DokumenLaporan;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string reportpath = Path.Combine(Application.StartupPath, "STRUK PEMBAYARAN DBZ HOTEL.rpt");

            try
            {
                if (!File.Exists(reportpath))
                {
                    MessageBox.Show(
                        "File report tidak ditemukan:\n" + reportpath, "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DokumenLaporan = new ReportDocument();
                DokumenLaporan.Load(reportpath);

                crystalReportViewer1.ReportSource = DokumenLaporan;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (DokumenLaporan != null)
                {
                    DokumenLaporan.Close();
                    DokumenLaporan.Dispose();
                    DokumenLaporan = null;
                }
            }
        }
    }
}


