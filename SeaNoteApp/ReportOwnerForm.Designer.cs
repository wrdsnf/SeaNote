namespace SeaNoteApp
{
    partial class ReportOwnerForm
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
            btnViewReport = new Button();
            cbReportType = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnViewReport
            // 
            btnViewReport.BackColor = Color.DodgerBlue;
            btnViewReport.FlatStyle = FlatStyle.Flat;
            btnViewReport.Location = new Point(93, 157);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(257, 46);
            btnViewReport.TabIndex = 5;
            btnViewReport.Text = "View Report";
            btnViewReport.UseVisualStyleBackColor = false;
            btnViewReport.Click += btnViewReport_Click;
            // 
            // cbReportType
            // 
            cbReportType.FormattingEnabled = true;
            cbReportType.Items.AddRange(new object[] { "Ships", "Trips", "Maintenance" });
            cbReportType.Location = new Point(348, 75);
            cbReportType.Name = "cbReportType";
            cbReportType.Size = new Size(242, 40);
            cbReportType.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 75);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 3;
            label1.Text = "Select Report Type :";
            // 
            // ReportOwnerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 279);
            Controls.Add(btnViewReport);
            Controls.Add(cbReportType);
            Controls.Add(label1);
            Name = "ReportOwnerForm";
            Text = "View Report (Owner)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewReport;
        private ComboBox cbReportType;
        private Label label1;
    }
}