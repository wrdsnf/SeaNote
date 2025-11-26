namespace SeaNoteApp
{
    partial class LogManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.TextBox tbJenisLog;
        private System.Windows.Forms.RichTextBox tbIsiLog;
        private System.Windows.Forms.DateTimePicker dtpTanggalLog; 
        private System.Windows.Forms.Button btnDeleteLog;
        private System.Windows.Forms.Button btnUpdateLog;
        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3; 
        private System.Windows.Forms.Label label4; 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewLogs = new DataGridView();
            tbJenisLog = new TextBox();
            btnDeleteLog = new Button();
            btnUpdateLog = new Button();
            btnAddLog = new Button();
            label1 = new Label();
            label2 = new Label();
            tbIsiLog = new RichTextBox();
            label3 = new Label();
            dtpTanggalLog = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(12, 357);
            dataGridViewLogs.MultiSelect = false;
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.ReadOnly = true;
            dataGridViewLogs.RowHeadersWidth = 82;
            dataGridViewLogs.RowTemplate.Height = 25;
            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLogs.Size = new Size(894, 342);
            dataGridViewLogs.TabIndex = 0;
            dataGridViewLogs.CellClick += DataGridViewLogs_CellClick;
            // 
            // tbJenisLog
            // 
            tbJenisLog.Location = new Point(48, 127);
            tbJenisLog.Name = "tbJenisLog";
            tbJenisLog.Size = new Size(243, 39);
            tbJenisLog.TabIndex = 1;
            // 
            // btnDeleteLog
            // 
            btnDeleteLog.BackColor = Color.Tomato;
            btnDeleteLog.FlatStyle = FlatStyle.Flat;
            btnDeleteLog.ForeColor = Color.White;
            btnDeleteLog.Location = new Point(610, 255);
            btnDeleteLog.Name = "btnDeleteLog";
            btnDeleteLog.Size = new Size(253, 67);
            btnDeleteLog.TabIndex = 9;
            btnDeleteLog.Text = "Delete";
            btnDeleteLog.UseVisualStyleBackColor = false;
            btnDeleteLog.Click += BtnDeleteLog_Click;
            // 
            // btnUpdateLog
            // 
            btnUpdateLog.FlatStyle = FlatStyle.Flat;
            btnUpdateLog.Location = new Point(610, 174);
            btnUpdateLog.Name = "btnUpdateLog";
            btnUpdateLog.Size = new Size(253, 67);
            btnUpdateLog.TabIndex = 8;
            btnUpdateLog.Text = "Update";
            btnUpdateLog.UseVisualStyleBackColor = true;
            btnUpdateLog.Click += BtnUpdateLog_Click;
            // 
            // btnAddLog
            // 
            btnAddLog.BackColor = Color.DodgerBlue;
            btnAddLog.FlatStyle = FlatStyle.Flat;
            btnAddLog.ForeColor = Color.White;
            btnAddLog.Location = new Point(610, 92);
            btnAddLog.Name = "btnAddLog";
            btnAddLog.Size = new Size(253, 67);
            btnAddLog.TabIndex = 7;
            btnAddLog.Text = "Add";
            btnAddLog.UseVisualStyleBackColor = false;
            btnAddLog.Click += BtnAddLog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 92);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 10;
            label1.Text = "Jenis Log:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 189);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 11;
            label2.Text = "Isi Log:";
            // 
            // tbIsiLog
            // 
            tbIsiLog.Location = new Point(48, 224);
            tbIsiLog.Name = "tbIsiLog";
            tbIsiLog.Size = new Size(506, 97);
            tbIsiLog.TabIndex = 12;
            tbIsiLog.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(48, 27);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 13;
            // 
            // dtpTanggalLog
            // 
            dtpTanggalLog.Format = DateTimePickerFormat.Short;
            dtpTanggalLog.Location = new Point(315, 127);
            dtpTanggalLog.Name = "dtpTanggalLog";
            dtpTanggalLog.Size = new Size(239, 39);
            dtpTanggalLog.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 92);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 15;
            label4.Text = "Tanggal Log:";
            // 
            // LogManagementForm
            // 
            ClientSize = new Size(918, 720);
            Controls.Add(label4);
            Controls.Add(dtpTanggalLog);
            Controls.Add(label3);
            Controls.Add(tbIsiLog);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteLog);
            Controls.Add(btnUpdateLog);
            Controls.Add(btnAddLog);
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