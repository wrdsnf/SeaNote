namespace SeaNoteApp
{
    partial class ExportReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Button btnExportCsv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cbReportType = new ComboBox();
            btnExportCsv = new Button();
            SuspendLayout();
            // 
            // cbReportType
            // 
            cbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReportType.FormattingEnabled = true;
            cbReportType.Items.AddRange(new object[] { "Users", "Kapal", "Trips", "Maintenance", "Logs" });
            cbReportType.Location = new Point(12, 12);
            cbReportType.Name = "cbReportType";
            cbReportType.Size = new Size(200, 40);
            cbReportType.TabIndex = 0;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.DodgerBlue;
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.ForeColor = Color.White;
            btnExportCsv.Location = new Point(220, 12);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(90, 23);
            btnExportCsv.TabIndex = 1;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // ExportReportForm
            // 
            ClientSize = new Size(334, 61);
            Controls.Add(btnExportCsv);
            Controls.Add(cbReportType);
            Name = "ExportReportForm";
            Text = "Export Report";
            ResumeLayout(false);
        }
    }
}
