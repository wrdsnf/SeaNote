namespace SeaNoteApp
{
    partial class ReportOwnerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewReports = new DataGridView();
            panelTop = new Panel();
            btnFilter = new Button();
            dtpTo = new DateTimePicker();
            labelTo = new Label();
            dtpFrom = new DateTimePicker();
            labelFrom = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.AllowUserToAddRows = false;
            dataGridViewReports.AllowUserToDeleteRows = false;
            dataGridViewReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.Dock = DockStyle.Fill;
            dataGridViewReports.Location = new Point(0, 139);
            dataGridViewReports.Margin = new Padding(6, 6, 6, 6);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.ReadOnly = true;
            dataGridViewReports.RowHeadersWidth = 82;
            dataGridViewReports.RowTemplate.Height = 25;
            dataGridViewReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReports.Size = new Size(1336, 641);
            dataGridViewReports.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnFilter);
            panelTop.Controls.Add(dtpTo);
            panelTop.Controls.Add(labelTo);
            panelTop.Controls.Add(dtpFrom);
            panelTop.Controls.Add(labelFrom);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(6, 6, 6, 6);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1336, 139);
            panelTop.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.DodgerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(986, 24);
            btnFilter.Margin = new Padding(6, 6, 6, 6);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(252, 86);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter Laporan";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += BtnFilter_Click;
            // 
            // dtpTo
            // 
            dtpTo.CalendarMonthBackground = Color.Transparent;
            dtpTo.Location = new Point(591, 46);
            dtpTo.Margin = new Padding(6, 6, 6, 6);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(331, 39);
            dtpTo.TabIndex = 3;
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(532, 51);
            labelTo.Margin = new Padding(6, 0, 6, 0);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(47, 32);
            labelTo.TabIndex = 2;
            labelTo.Text = "s/d";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarMonthBackground = Color.Transparent;
            dtpFrom.Location = new Point(189, 46);
            dtpFrom.Margin = new Padding(6, 6, 6, 6);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(331, 39);
            dtpFrom.TabIndex = 1;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(28, 51);
            labelFrom.Margin = new Padding(6, 0, 6, 0);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(151, 32);
            labelFrom.TabIndex = 0;
            labelFrom.Text = "Dari Tanggal:";
            // 
            // ReportOwnerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 780);
            Controls.Add(dataGridViewReports);
            Controls.Add(panelTop);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ReportOwnerForm";
            Text = "Laporan Trip (Owner)";
            Load += ReportOwnerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DataGridView dataGridViewReports;
    }
}