namespace SeaNoteApp
{
    partial class DashboardAdminForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnTestPoli = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnShipManagement = new Button();
            btnTripManagement = new Button();
            btnMaintenanceAdmin = new Button();
            btnExportReport = new Button();
            btnUserManagement = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1318, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 36);
            fileToolStripMenuItem.Text = "...";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(222, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(381, 32);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(571, 72);
            label1.TabIndex = 1;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // btnTestPoli
            // 
            btnTestPoli.BackColor = SystemColors.ActiveCaption;
            btnTestPoli.FlatStyle = FlatStyle.Flat;
            btnTestPoli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTestPoli.ForeColor = Color.White;
            btnTestPoli.Location = new Point(1134, 32);
            btnTestPoli.Name = "btnTestPoli";
            btnTestPoli.Size = new Size(150, 62);
            btnTestPoli.TabIndex = 9;
            btnTestPoli.Text = "Poly Test";
            btnTestPoli.UseVisualStyleBackColor = false;
            btnTestPoli.Click += btnTestPoli_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTestPoli);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 135);
            panel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnShipManagement, 0, 0);
            tableLayoutPanel2.Controls.Add(btnTripManagement, 0, 1);
            tableLayoutPanel2.Controls.Add(btnMaintenanceAdmin, 0, 2);
            tableLayoutPanel2.Controls.Add(btnExportReport, 0, 3);
            tableLayoutPanel2.Controls.Add(btnUserManagement, 0, 4);
            tableLayoutPanel2.Location = new Point(30, 3);
            tableLayoutPanel2.Margin = new Padding(30, 3, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(270, 586);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnShipManagement
            // 
            btnShipManagement.Dock = DockStyle.Fill;
            btnShipManagement.Location = new Point(6, 6);
            btnShipManagement.Margin = new Padding(6);
            btnShipManagement.Name = "btnShipManagement";
            btnShipManagement.Size = new Size(258, 105);
            btnShipManagement.TabIndex = 11;
            btnShipManagement.Text = "Manage Ships";
            btnShipManagement.UseVisualStyleBackColor = true;
            btnShipManagement.Click += BtnShipManagement_Click;
            // 
            // btnTripManagement
            // 
            btnTripManagement.Dock = DockStyle.Fill;
            btnTripManagement.Location = new Point(6, 123);
            btnTripManagement.Margin = new Padding(6);
            btnTripManagement.Name = "btnTripManagement";
            btnTripManagement.Size = new Size(258, 105);
            btnTripManagement.TabIndex = 10;
            btnTripManagement.Text = "Manage Trips";
            btnTripManagement.UseVisualStyleBackColor = true;
            btnTripManagement.Click += BtnTripManagement_Click;
            // 
            // btnMaintenanceAdmin
            // 
            btnMaintenanceAdmin.Dock = DockStyle.Fill;
            btnMaintenanceAdmin.Location = new Point(6, 240);
            btnMaintenanceAdmin.Margin = new Padding(6);
            btnMaintenanceAdmin.Name = "btnMaintenanceAdmin";
            btnMaintenanceAdmin.Size = new Size(258, 105);
            btnMaintenanceAdmin.TabIndex = 9;
            btnMaintenanceAdmin.Text = "Manage Maintenance";
            btnMaintenanceAdmin.UseVisualStyleBackColor = true;
            btnMaintenanceAdmin.Click += BtnMaintenanceAdmin_Click;
            // 
            // btnExportReport
            // 
            btnExportReport.Dock = DockStyle.Fill;
            btnExportReport.Location = new Point(6, 357);
            btnExportReport.Margin = new Padding(6);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(258, 105);
            btnExportReport.TabIndex = 8;
            btnExportReport.Text = "Export Reports";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += BtnExportReport_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Dock = DockStyle.Fill;
            btnUserManagement.Location = new Point(6, 474);
            btnUserManagement.Margin = new Padding(6);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(258, 106);
            btnUserManagement.TabIndex = 7;
            btnUserManagement.Text = "Manage Users";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += BtnUserManagement_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 179);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1318, 744);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel2, 0, 0);
            tableLayoutPanel6.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel6.Controls.Add(label8, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(362, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 34.28184F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 9.07859F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 56.7750664F));
            tableLayoutPanel6.Size = new Size(953, 738);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 246);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(label7, 0, 1);
            tableLayoutPanel5.Location = new Point(652, 39);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanel5.Size = new Size(250, 174);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SteelBlue;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(244, 47);
            label6.TabIndex = 0;
            label6.Text = "Users Count";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SteelBlue;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 47);
            label7.Name = "label7";
            label7.Size = new Size(244, 127);
            label7.TabIndex = 1;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Location = new Point(39, 39);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(256, 174);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 47);
            label2.TabIndex = 0;
            label2.Text = "Ships Count";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(250, 127);
            label3.TabIndex = 1;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Location = new Point(350, 39);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanel4.Size = new Size(250, 174);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(244, 47);
            label4.TabIndex = 0;
            label4.Text = "Trips Count";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 47);
            label5.Name = "label5";
            label5.Size = new Size(244, 127);
            label5.TabIndex = 1;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(20, 338);
            dataGridView1.Margin = new Padding(20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(913, 380);
            dataGridView1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(20, 252);
            label8.Margin = new Padding(20, 0, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(930, 66);
            label8.TabIndex = 2;
            label8.Text = "Aktivitas Terakhir:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 923);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "DashboardAdminForm";
            Text = "Admin Dashboard";
            Load += DashboardAdminForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private Button btnTestPoli;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnUserManagement;
        private Button btnExportReport;
        private Button btnMaintenanceAdmin;
        private Button btnTripManagement;
        private Button btnShipManagement;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Label label5;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label8;
    }
}