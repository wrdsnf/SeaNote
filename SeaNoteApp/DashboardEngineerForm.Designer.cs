namespace SeaNoteApp
{
    partial class DashboardEngineerForm
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
            btnMaintenanceEngineer = new Button();
            panelHeader = new Panel();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelMenu = new TableLayoutPanel();
            btnMaintenanceHistory = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            labelWeatherTemp = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            labelWeatherDesc = new Label();
            labelWeatherCity = new Label();
            panelCounts = new Panel();
            tableLayoutPanelCard2 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanelCard1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            panelHeader.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelMenu.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panelCounts.SuspendLayout();
            tableLayoutPanelCard2.SuspendLayout();
            tableLayoutPanelCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(811, 84);
            label1.TabIndex = 1;
            label1.Text = "ENGINEER DASHBOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMaintenanceEngineer
            // 
            btnMaintenanceEngineer.Dock = DockStyle.Fill;
            btnMaintenanceEngineer.Location = new Point(4, 4);
            btnMaintenanceEngineer.Margin = new Padding(4);
            btnMaintenanceEngineer.Name = "btnMaintenanceEngineer";
            btnMaintenanceEngineer.Size = new Size(151, 57);
            btnMaintenanceEngineer.TabIndex = 2;
            btnMaintenanceEngineer.Text = "Manage Maintenance";
            btnMaintenanceEngineer.UseVisualStyleBackColor = true;
            btnMaintenanceEngineer.Click += BtnMaintenanceEngineer_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 28);
            panelHeader.Margin = new Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(811, 84);
            panelHeader.TabIndex = 4;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelMenu, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelContent, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 112);
            tableLayoutPanelMain.Margin = new Padding(2);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(811, 505);
            tableLayoutPanelMain.TabIndex = 5;
            // 
            // tableLayoutPanelMenu
            // 
            tableLayoutPanelMenu.ColumnCount = 1;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Controls.Add(btnMaintenanceEngineer, 0, 0);
            tableLayoutPanelMenu.Controls.Add(btnMaintenanceHistory, 0, 1);
            tableLayoutPanelMenu.Location = new Point(18, 2);
            tableLayoutPanelMenu.Margin = new Padding(18, 2, 2, 2);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 2;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.Size = new Size(159, 131);
            tableLayoutPanelMenu.TabIndex = 0;
            // 
            // btnMaintenanceHistory
            // 
            btnMaintenanceHistory.Dock = DockStyle.Fill;
            btnMaintenanceHistory.Location = new Point(4, 69);
            btnMaintenanceHistory.Margin = new Padding(4);
            btnMaintenanceHistory.Name = "btnMaintenanceHistory";
            btnMaintenanceHistory.Size = new Size(151, 58);
            btnMaintenanceHistory.TabIndex = 3;
            btnMaintenanceHistory.Text = "View History";
            btnMaintenanceHistory.UseVisualStyleBackColor = true;
            btnMaintenanceHistory.Click += BtnMaintenanceHistory_Click;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.BackColor = Color.White;
            tableLayoutPanelContent.ColumnCount = 1;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelContent.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanelContent.Controls.Add(panelCounts, 0, 1);
            tableLayoutPanelContent.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanelContent.Controls.Add(label8, 0, 2);
            tableLayoutPanelContent.Dock = DockStyle.Fill;
            tableLayoutPanelContent.Location = new Point(223, 2);
            tableLayoutPanelContent.Margin = new Padding(2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 4;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 25.948103F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9560871F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 3.79241514F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 47.77778F));
            tableLayoutPanelContent.Size = new Size(586, 501);
            tableLayoutPanelContent.TabIndex = 4;
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
            tableLayoutPanel7.Size = new Size(538, 120);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // labelWeatherTemp
            // 
            labelWeatherTemp.AutoSize = true;
            labelWeatherTemp.BackColor = Color.WhiteSmoke;
            labelWeatherTemp.Dock = DockStyle.Fill;
            labelWeatherTemp.Font = new Font("Alte Haas Grotesk", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeatherTemp.ForeColor = Color.Silver;
            labelWeatherTemp.Location = new Point(204, 35);
            labelWeatherTemp.Margin = new Padding(5);
            labelWeatherTemp.Name = "labelWeatherTemp";
            labelWeatherTemp.Padding = new Padding(5);
            labelWeatherTemp.Size = new Size(129, 80);
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
            label11.Size = new Size(190, 20);
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
            label10.Size = new Size(129, 20);
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
            label9.Size = new Size(189, 20);
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
            labelWeatherDesc.Location = new Point(343, 35);
            labelWeatherDesc.Margin = new Padding(5);
            labelWeatherDesc.Name = "labelWeatherDesc";
            labelWeatherDesc.Padding = new Padding(5);
            labelWeatherDesc.Size = new Size(190, 80);
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
            labelWeatherCity.Location = new Point(5, 35);
            labelWeatherCity.Margin = new Padding(5);
            labelWeatherCity.Name = "labelWeatherCity";
            labelWeatherCity.Padding = new Padding(5);
            labelWeatherCity.Size = new Size(189, 80);
            labelWeatherCity.TabIndex = 3;
            labelWeatherCity.Text = "City";
            labelWeatherCity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCounts
            // 
            panelCounts.BackColor = Color.White;
            panelCounts.Controls.Add(tableLayoutPanelCard2);
            panelCounts.Controls.Add(tableLayoutPanelCard1);
            panelCounts.Dock = DockStyle.Fill;
            panelCounts.Location = new Point(2, 132);
            panelCounts.Margin = new Padding(2);
            panelCounts.Name = "panelCounts";
            panelCounts.Size = new Size(582, 106);
            panelCounts.TabIndex = 0;
            // 
            // tableLayoutPanelCard2
            // 
            tableLayoutPanelCard2.BackColor = Color.Transparent;
            tableLayoutPanelCard2.ColumnCount = 1;
            tableLayoutPanelCard2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCard2.Controls.Add(label4, 0, 0);
            tableLayoutPanelCard2.Controls.Add(label5, 0, 1);
            tableLayoutPanelCard2.Location = new Point(361, 11);
            tableLayoutPanelCard2.Margin = new Padding(2);
            tableLayoutPanelCard2.Name = "tableLayoutPanelCard2";
            tableLayoutPanelCard2.RowCount = 2;
            tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanelCard2.Size = new Size(158, 88);
            tableLayoutPanelCard2.TabIndex = 1;
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
            label4.Size = new Size(154, 24);
            label4.TabIndex = 0;
            label4.Text = "Total Selesai";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 24);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 64);
            label5.TabIndex = 1;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelCard1
            // 
            tableLayoutPanelCard1.BackColor = Color.Transparent;
            tableLayoutPanelCard1.ColumnCount = 1;
            tableLayoutPanelCard1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCard1.Controls.Add(label2, 0, 0);
            tableLayoutPanelCard1.Controls.Add(label3, 0, 1);
            tableLayoutPanelCard1.Location = new Point(54, 11);
            tableLayoutPanelCard1.Margin = new Padding(2);
            tableLayoutPanelCard1.Name = "tableLayoutPanelCard1";
            tableLayoutPanelCard1.RowCount = 2;
            tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanelCard1.Size = new Size(269, 88);
            tableLayoutPanelCard1.TabIndex = 0;
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
            label2.Size = new Size(265, 24);
            label2.TabIndex = 0;
            label2.Text = "Pending Maintenance";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(265, 64);
            label3.TabIndex = 1;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(12, 271);
            dataGridView1.Margin = new Padding(12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(562, 218);
            dataGridView1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(12, 240);
            label8.Margin = new Padding(12, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(572, 19);
            label8.TabIndex = 2;
            label8.Text = "Aktivitas Terakhir Anda:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DashboardEngineerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 617);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(panelHeader);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "DashboardEngineerForm";
            Text = "Engineer Dashboard";
            Load += DashboardEngineerForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelHeader.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMenu.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panelCounts.ResumeLayout(false);
            tableLayoutPanelCard2.ResumeLayout(false);
            tableLayoutPanelCard2.PerformLayout();
            tableLayoutPanelCard1.ResumeLayout(false);
            tableLayoutPanelCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaintenanceEngineer;
        private Panel panelHeader;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelMenu;
        private TableLayoutPanel tableLayoutPanelContent;
        private Panel panelCounts;
        private TableLayoutPanel tableLayoutPanelCard2;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanelCard1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label8;
        private Button btnMaintenanceHistory;
        private TableLayoutPanel tableLayoutPanel7;
        private Label labelWeatherTemp;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label labelWeatherDesc;
        private Label labelWeatherCity;
    }
}