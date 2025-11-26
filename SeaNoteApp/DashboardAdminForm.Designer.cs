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
            tableLayoutPanel7 = new TableLayoutPanel();
            labelWeatherTemp = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            labelWeatherDesc = new Label();
            labelWeatherCity = new Label();
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
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(811, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(32, 24);
            fileToolStripMenuItem.Text = "...";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(234, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(360, 46);
            label1.TabIndex = 1;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // btnTestPoli
            // 
            btnTestPoli.BackColor = SystemColors.ActiveCaption;
            btnTestPoli.FlatStyle = FlatStyle.Flat;
            btnTestPoli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTestPoli.ForeColor = Color.White;
            btnTestPoli.Location = new Point(698, 20);
            btnTestPoli.Margin = new Padding(2);
            btnTestPoli.Name = "btnTestPoli";
            btnTestPoli.Size = new Size(92, 39);
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
            panel1.Location = new Point(0, 28);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 84);
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
            tableLayoutPanel2.Location = new Point(18, 2);
            tableLayoutPanel2.Margin = new Padding(18, 2, 2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(166, 366);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnShipManagement
            // 
            btnShipManagement.Dock = DockStyle.Fill;
            btnShipManagement.Location = new Point(4, 4);
            btnShipManagement.Margin = new Padding(4);
            btnShipManagement.Name = "btnShipManagement";
            btnShipManagement.Size = new Size(158, 65);
            btnShipManagement.TabIndex = 11;
            btnShipManagement.Text = "Manage Ships";
            btnShipManagement.UseVisualStyleBackColor = true;
            btnShipManagement.Click += BtnShipManagement_Click;
            // 
            // btnTripManagement
            // 
            btnTripManagement.Dock = DockStyle.Fill;
            btnTripManagement.Location = new Point(4, 77);
            btnTripManagement.Margin = new Padding(4);
            btnTripManagement.Name = "btnTripManagement";
            btnTripManagement.Size = new Size(158, 65);
            btnTripManagement.TabIndex = 10;
            btnTripManagement.Text = "Manage Trips";
            btnTripManagement.UseVisualStyleBackColor = true;
            btnTripManagement.Click += BtnTripManagement_Click;
            // 
            // btnMaintenanceAdmin
            // 
            btnMaintenanceAdmin.Dock = DockStyle.Fill;
            btnMaintenanceAdmin.Location = new Point(4, 150);
            btnMaintenanceAdmin.Margin = new Padding(4);
            btnMaintenanceAdmin.Name = "btnMaintenanceAdmin";
            btnMaintenanceAdmin.Size = new Size(158, 65);
            btnMaintenanceAdmin.TabIndex = 9;
            btnMaintenanceAdmin.Text = "Manage Maintenance";
            btnMaintenanceAdmin.UseVisualStyleBackColor = true;
            btnMaintenanceAdmin.Click += BtnMaintenanceAdmin_Click;
            // 
            // btnExportReport
            // 
            btnExportReport.Dock = DockStyle.Fill;
            btnExportReport.Location = new Point(4, 223);
            btnExportReport.Margin = new Padding(4);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(158, 65);
            btnExportReport.TabIndex = 8;
            btnExportReport.Text = "Export Reports";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += BtnExportReport_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Dock = DockStyle.Fill;
            btnUserManagement.Location = new Point(4, 296);
            btnUserManagement.Margin = new Padding(4);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(158, 66);
            btnUserManagement.TabIndex = 7;
            btnUserManagement.Text = "Manage Users";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += BtnUserManagement_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 112);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(811, 505);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel2, 0, 1);
            tableLayoutPanel6.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel6.Controls.Add(label8, 0, 2);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(223, 2);
            tableLayoutPanel6.Margin = new Padding(2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 4;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5469055F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 23.3532925F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 4.39121771F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 45.7085838F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(586, 501);
            tableLayoutPanel6.TabIndex = 4;
            tableLayoutPanel6.Paint += tableLayoutPanel6_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 135);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 113);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(label7, 0, 1);
            tableLayoutPanel5.Location = new Point(401, 13);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanel5.Size = new Size(154, 85);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SteelBlue;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 0);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
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
            label7.Location = new Point(2, 23);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 62);
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
            tableLayoutPanel3.Location = new Point(24, 13);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel3.Size = new Size(158, 85);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
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
            label3.Location = new Point(2, 23);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 62);
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
            tableLayoutPanel4.Location = new Point(215, 13);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanel4.Size = new Size(154, 85);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
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
            label5.Location = new Point(2, 23);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 62);
            label5.TabIndex = 1;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(12, 284);
            dataGridView1.Margin = new Padding(12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(562, 205);
            dataGridView1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(12, 250);
            label8.Margin = new Padding(12, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(572, 22);
            label8.TabIndex = 2;
            label8.Text = "Aktivitas Terakhir:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel7.BackColor = Color.White;
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tableLayoutPanel7.Controls.Add(labelWeatherTemp, 1, 1);
            tableLayoutPanel7.Controls.Add(label11, 2, 0);
            tableLayoutPanel7.Controls.Add(label10, 1, 0);
            tableLayoutPanel7.Controls.Add(label9, 0, 0);
            tableLayoutPanel7.Controls.Add(labelWeatherDesc, 2, 1);
            tableLayoutPanel7.Controls.Add(labelWeatherCity, 0, 1);
            tableLayoutPanel7.Enabled = false;
            tableLayoutPanel7.Location = new Point(24, 5);
            tableLayoutPanel7.Margin = new Padding(5);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25.2032528F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 74.7967453F));
            tableLayoutPanel7.Size = new Size(538, 123);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // labelWeatherTemp
            // 
            labelWeatherTemp.AutoSize = true;
            labelWeatherTemp.BackColor = Color.WhiteSmoke;
            labelWeatherTemp.Dock = DockStyle.Fill;
            labelWeatherTemp.Font = new Font("Alte Haas Grotesk", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeatherTemp.ForeColor = Color.Silver;
            labelWeatherTemp.Location = new Point(204, 36);
            labelWeatherTemp.Margin = new Padding(5);
            labelWeatherTemp.Name = "labelWeatherTemp";
            labelWeatherTemp.Padding = new Padding(5);
            labelWeatherTemp.Size = new Size(129, 82);
            labelWeatherTemp.TabIndex = 4;
            labelWeatherTemp.Text = "temp";
            labelWeatherTemp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(343, 5);
            label11.Margin = new Padding(5);
            label11.Name = "label11";
            label11.Size = new Size(190, 21);
            label11.TabIndex = 2;
            label11.Text = "Description";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(204, 5);
            label10.Margin = new Padding(5);
            label10.Name = "label10";
            label10.Size = new Size(129, 21);
            label10.TabIndex = 1;
            label10.Text = "Temperature";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(5, 5);
            label9.Margin = new Padding(5);
            label9.Name = "label9";
            label9.Size = new Size(189, 21);
            label9.TabIndex = 0;
            label9.Text = "City";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWeatherDesc
            // 
            labelWeatherDesc.AutoSize = true;
            labelWeatherDesc.BackColor = Color.WhiteSmoke;
            labelWeatherDesc.Dock = DockStyle.Fill;
            labelWeatherDesc.Font = new Font("Alte Haas Grotesk", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeatherDesc.ForeColor = Color.Silver;
            labelWeatherDesc.Location = new Point(343, 36);
            labelWeatherDesc.Margin = new Padding(5);
            labelWeatherDesc.Name = "labelWeatherDesc";
            labelWeatherDesc.Padding = new Padding(5);
            labelWeatherDesc.Size = new Size(190, 82);
            labelWeatherDesc.TabIndex = 5;
            labelWeatherDesc.Text = "desc";
            labelWeatherDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWeatherCity
            // 
            labelWeatherCity.AutoSize = true;
            labelWeatherCity.BackColor = Color.WhiteSmoke;
            labelWeatherCity.Dock = DockStyle.Fill;
            labelWeatherCity.Font = new Font("Alte Haas Grotesk", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeatherCity.ForeColor = Color.Silver;
            labelWeatherCity.Location = new Point(5, 36);
            labelWeatherCity.Margin = new Padding(5);
            labelWeatherCity.Name = "labelWeatherCity";
            labelWeatherCity.Padding = new Padding(5);
            labelWeatherCity.Size = new Size(189, 82);
            labelWeatherCity.TabIndex = 3;
            labelWeatherCity.Text = "City";
            labelWeatherCity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 617);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
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
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel7;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label labelWeatherDesc;
        private Label labelWeatherTemp;
        private Label labelWeatherCity;
    }
}