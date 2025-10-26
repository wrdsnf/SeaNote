namespace SeaNoteApp
{
    partial class LogManagementForm
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
            cbTrips = new ComboBox();
            dataGridViewLogs = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            tbJenisLog = new TextBox();
            label3 = new Label();
            tbIsiLog = new TextBox();
            btnAddLog = new Button();
            btnUpdateLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "Select Trip :";
            // 
            // cbTrips
            // 
            cbTrips.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrips.FormattingEnabled = true;
            cbTrips.Location = new Point(192, 30);
            cbTrips.Name = "cbTrips";
            cbTrips.Size = new Size(242, 40);
            cbTrips.TabIndex = 1;
            cbTrips.Click += cbTrips_SelectedIndexChanged;
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(12, 104);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.RowHeadersWidth = 82;
            dataGridViewLogs.Size = new Size(556, 500);
            dataGridViewLogs.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(tbJenisLog);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(tbIsiLog);
            flowLayoutPanel1.Controls.Add(btnAddLog);
            flowLayoutPanel1.Controls.Add(btnUpdateLog);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(574, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 529);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 0;
            label2.Text = "Jenis Log :";
            // 
            // tbJenisLog
            // 
            tbJenisLog.Location = new Point(133, 3);
            tbJenisLog.Name = "tbJenisLog";
            tbJenisLog.Size = new Size(200, 39);
            tbJenisLog.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(94, 32);
            label3.TabIndex = 2;
            label3.Text = "Isi Log :";
            // 
            // tbIsiLog
            // 
            tbIsiLog.Location = new Point(103, 48);
            tbIsiLog.Multiline = true;
            tbIsiLog.Name = "tbIsiLog";
            tbIsiLog.Size = new Size(280, 100);
            tbIsiLog.TabIndex = 3;
            // 
            // btnAddLog
            // 
            btnAddLog.BackColor = Color.DodgerBlue;
            btnAddLog.FlatStyle = FlatStyle.Flat;
            btnAddLog.ForeColor = Color.White;
            btnAddLog.Location = new Point(3, 154);
            btnAddLog.Name = "btnAddLog";
            btnAddLog.Size = new Size(150, 46);
            btnAddLog.TabIndex = 4;
            btnAddLog.Text = "Add Log";
            btnAddLog.UseVisualStyleBackColor = false;
            btnAddLog.Click += btnAddLog_Click;
            // 
            // btnUpdateLog
            // 
            btnUpdateLog.BackColor = Color.Gainsboro;
            btnUpdateLog.FlatStyle = FlatStyle.Flat;
            btnUpdateLog.ForeColor = Color.Black;
            btnUpdateLog.Location = new Point(159, 154);
            btnUpdateLog.Name = "btnUpdateLog";
            btnUpdateLog.Size = new Size(150, 46);
            btnUpdateLog.TabIndex = 5;
            btnUpdateLog.Text = "Update Log";
            btnUpdateLog.UseVisualStyleBackColor = false;
            btnUpdateLog.Click += btnUpdateLog_Click;
            // 
            // LogManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 529);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridViewLogs);
            Controls.Add(cbTrips);
            Controls.Add(label1);
            Name = "LogManagementForm";
            Text = "Log Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbTrips;
        private DataGridView dataGridViewLogs;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox tbJenisLog;
        private Label label3;
        private TextBox tbIsiLog;
        private Button btnAddLog;
        private Button btnUpdateLog;
    }
}