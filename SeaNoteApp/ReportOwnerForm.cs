using System;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class ReportOwnerForm : Form
    {
        public ReportOwnerForm()
        {
            InitializeComponent();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (cbReportType.SelectedItem == null)
            {
                MessageBox.Show("Pilih jenis report dulu.");
                return;
            }
            string reportType = cbReportType.SelectedItem.ToString() ?? "";

            // TODO: Tampilkan data report di form/grid baru

            MessageBox.Show($"Viewing report: {reportType}...\n(Logic view belum diimplementasi)");
        }
    }
}