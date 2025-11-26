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
            lbl_typeExp = new Label();
            SuspendLayout();
            // 
            // cbReportType
            // 
            cbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReportType.FormattingEnabled = true;
            cbReportType.Items.AddRange(new object[] { "Users", "Kapal", "Trips", "Maintenance", "Logs" });
            cbReportType.Location = new Point(12, 12);
            cbReportType.Name = "cbReportType";
            cbReportType.Size = new Size(200, 28);
            cbReportType.TabIndex = 0;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.DodgerBlue;
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.ForeColor = Color.White;
            btnExportCsv.Location = new Point(220, 12);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(90, 28);
            btnExportCsv.TabIndex = 1;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // lbl_typeExp
            // 
            lbl_typeExp.AutoSize = true;
            lbl_typeExp.Location = new Point(23, 30);
            lbl_typeExp.Name = "lbl_typeExp";
            lbl_typeExp.Size = new Size(110, 15);
            lbl_typeExp.TabIndex = 2;
            lbl_typeExp.Text = "Select Report Type :";
            // 
            // ExportReportForm
            // 
            ClientSize = new Size(334, 61);
            Controls.Add(btnExportCsv);
            Controls.Add(cbReportType);
            Name = "ExportReportForm";
            Text = "Export Report";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lbl_typeExp;
    }
}
