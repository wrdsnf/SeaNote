using System;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class ExportReportForm : Form
    {
        public ExportReportForm()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cbReportType.SelectedItem == null)
            {
                MessageBox.Show("Pilih jenis report dulu.");
                return;
            }
            string reportType = cbReportType.SelectedItem.ToString() ?? "";

            // TODO: Tambahin logic export ke CSV/PDF

            MessageBox.Show($"Exporting report: {reportType}...\n(Logic export belum diimplementasi)");
        }
    }
}