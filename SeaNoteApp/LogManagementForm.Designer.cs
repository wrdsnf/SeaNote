namespace SeaNoteApp
{
    partial class LogManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.TextBox tbJenisLog;
        private System.Windows.Forms.TextBox tbIsiLog;
        private System.Windows.Forms.DateTimePicker dtpTanggalLog;
        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.Button btnUpdateLog;
        private System.Windows.Forms.Button btnDeleteLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewLogs = new DataGridView();
            tbJenisLog = new TextBox();
            tbIsiLog = new TextBox();
            dtpTanggalLog = new DateTimePicker();
            btnAddLog = new Button();
            btnUpdateLog = new Button();
            btnDeleteLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(12, 144);
            dataGridViewLogs.MultiSelect = false;
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.ReadOnly = true;
            dataGridViewLogs.RowHeadersWidth = 82;
            dataGridViewLogs.RowTemplate.Height = 25;
            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLogs.Size = new Size(759, 322);
            dataGridViewLogs.TabIndex = 0;
            dataGridViewLogs.CellClick += DataGridViewLogs_CellClick;
            // 
            // tbJenisLog
            // 
            tbJenisLog.Location = new Point(12, 12);
            tbJenisLog.Name = "tbJenisLog";
            tbJenisLog.Size = new Size(200, 39);
            tbJenisLog.TabIndex = 1;
            // 
            // tbIsiLog
            // 
            tbIsiLog.Location = new Point(230, 12);
            tbIsiLog.Name = "tbIsiLog";
            tbIsiLog.Size = new Size(350, 39);
            tbIsiLog.TabIndex = 2;
            // 
            // dtpTanggalLog
            // 
            dtpTanggalLog.Location = new Point(600, 12);
            dtpTanggalLog.Name = "dtpTanggalLog";
            dtpTanggalLog.Size = new Size(170, 39);
            dtpTanggalLog.TabIndex = 3;
            // 
            // btnAddLog
            // 
            btnAddLog.BackColor = Color.DodgerBlue;
            btnAddLog.FlatStyle = FlatStyle.Flat;
            btnAddLog.ForeColor = Color.White;
            btnAddLog.Location = new Point(12, 81);
            btnAddLog.Name = "btnAddLog";
            btnAddLog.Size = new Size(137, 45);
            btnAddLog.TabIndex = 4;
            btnAddLog.Text = "Add";
            btnAddLog.UseVisualStyleBackColor = false;
            btnAddLog.Click += BtnAddLog_Click;
            // 
            // btnUpdateLog
            // 
            btnUpdateLog.FlatStyle = FlatStyle.Flat;
            btnUpdateLog.Location = new Point(166, 81);
            btnUpdateLog.Name = "btnUpdateLog";
            btnUpdateLog.Size = new Size(137, 45);
            btnUpdateLog.TabIndex = 5;
            btnUpdateLog.Text = "Update";
            btnUpdateLog.UseVisualStyleBackColor = true;
            btnUpdateLog.Click += BtnUpdateLog_Click;
            // 
            // btnDeleteLog
            // 
            btnDeleteLog.BackColor = Color.Tomato;
            btnDeleteLog.FlatStyle = FlatStyle.Flat;
            btnDeleteLog.ForeColor = Color.White;
            btnDeleteLog.Location = new Point(322, 81);
            btnDeleteLog.Name = "btnDeleteLog";
            btnDeleteLog.Size = new Size(137, 45);
            btnDeleteLog.TabIndex = 6;
            btnDeleteLog.Text = "Delete";
            btnDeleteLog.UseVisualStyleBackColor = false;
            btnDeleteLog.Click += BtnDeleteLog_Click;
            // 
            // LogManagementForm
            // 
            ClientSize = new Size(783, 466);
            Controls.Add(btnDeleteLog);
            Controls.Add(btnUpdateLog);
            Controls.Add(btnAddLog);
            Controls.Add(dtpTanggalLog);
            Controls.Add(tbIsiLog);
            Controls.Add(tbJenisLog);
            Controls.Add(dataGridViewLogs);
            Name = "LogManagementForm";
            Text = "Log Management";
            Load += LogManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
