namespace SeaNoteApp
{
    partial class ExportReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbReportType = new ComboBox();
            btnExport = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 41);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 0;
            label1.Text = "Select Report Type :";
            // 
            // cbReportType
            // 
            cbReportType.FormattingEnabled = true;
            cbReportType.Items.AddRange(new object[] { "Ships", "Trips", "Maintenance" });
            cbReportType.Location = new Point(298, 41);
            cbReportType.Name = "cbReportType";
            cbReportType.Size = new Size(242, 40);
            cbReportType.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.DodgerBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Location = new Point(43, 123);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(257, 46);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export to CSV/PDF";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // ExportReportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 227);
            Controls.Add(btnExport);
            Controls.Add(cbReportType);
            Controls.Add(label1);
            Name = "ExportReportForm";
            Text = "Export Report (Admin)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbReportType;
        private Button btnExport;
    }
}