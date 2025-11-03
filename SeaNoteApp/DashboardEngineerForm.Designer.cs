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
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(1318, 135);
            label1.TabIndex = 1;
            label1.Text = "ENGINEER DASHBOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMaintenanceEngineer
            // 
            btnMaintenanceEngineer.Dock = DockStyle.Fill;
            btnMaintenanceEngineer.Location = new Point(6, 6);
            btnMaintenanceEngineer.Margin = new Padding(6);
            btnMaintenanceEngineer.Name = "btnMaintenanceEngineer";
            btnMaintenanceEngineer.Size = new Size(246, 93);
            btnMaintenanceEngineer.TabIndex = 2;
            btnMaintenanceEngineer.Text = "Manage Maintenance";
            btnMaintenanceEngineer.UseVisualStyleBackColor = true;
            btnMaintenanceEngineer.Click += BtnMaintenanceEngineer_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 44);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1318, 135);
            panelHeader.TabIndex = 4;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 359F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelMenu, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelContent, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 179);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1318, 744);
            tableLayoutPanelMain.TabIndex = 5;
            // 
            // tableLayoutPanelMenu
            // 
            tableLayoutPanelMenu.ColumnCount = 1;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Controls.Add(btnMaintenanceEngineer, 0, 0);
            tableLayoutPanelMenu.Controls.Add(btnMaintenanceHistory, 0, 1);
            tableLayoutPanelMenu.Location = new Point(30, 3);
            tableLayoutPanelMenu.Margin = new Padding(30, 3, 3, 3);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 2;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.Size = new Size(258, 210);
            tableLayoutPanelMenu.TabIndex = 0;
            // 
            // btnMaintenanceHistory
            // 
            btnMaintenanceHistory.Dock = DockStyle.Fill;
            btnMaintenanceHistory.Location = new Point(6, 111);
            btnMaintenanceHistory.Margin = new Padding(6);
            btnMaintenanceHistory.Name = "btnMaintenanceHistory";
            btnMaintenanceHistory.Size = new Size(246, 93);
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
            tableLayoutPanelContent.Controls.Add(panelCounts, 0, 0);
            tableLayoutPanelContent.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanelContent.Controls.Add(label8, 0, 1);
            tableLayoutPanelContent.Dock = DockStyle.Fill;
            tableLayoutPanelContent.Location = new Point(362, 3);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 3;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 34.2320747F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 9.067306F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 56.70062F));
            tableLayoutPanelContent.Size = new Size(953, 738);
            tableLayoutPanelContent.TabIndex = 4;
            // 
            // panelCounts
            // 
            panelCounts.BackColor = Color.White;
            panelCounts.Controls.Add(tableLayoutPanelCard2);
            panelCounts.Controls.Add(tableLayoutPanelCard1);
            panelCounts.Dock = DockStyle.Fill;
            panelCounts.Location = new Point(3, 3);
            panelCounts.Name = "panelCounts";
            panelCounts.Size = new Size(947, 246);
            panelCounts.TabIndex = 0;
            // 
            // tableLayoutPanelCard2
            // 
            tableLayoutPanelCard2.BackColor = Color.Transparent;
            tableLayoutPanelCard2.ColumnCount = 1;
            tableLayoutPanelCard2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCard2.Controls.Add(label4, 0, 0);
            tableLayoutPanelCard2.Controls.Add(label5, 0, 1);
            tableLayoutPanelCard2.Location = new Point(565, 39);
            tableLayoutPanelCard2.Name = "tableLayoutPanelCard2";
            tableLayoutPanelCard2.RowCount = 2;
            tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanelCard2.Size = new Size(256, 174);
            tableLayoutPanelCard2.TabIndex = 1;
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
            label4.Size = new Size(250, 47);
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
            label5.Location = new Point(3, 47);
            label5.Name = "label5";
            label5.Size = new Size(250, 127);
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
            tableLayoutPanelCard1.Location = new Point(66, 39);
            tableLayoutPanelCard1.Name = "tableLayoutPanelCard1";
            tableLayoutPanelCard1.RowCount = 2;
            tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.5F));
            tableLayoutPanelCard1.Size = new Size(437, 174);
            tableLayoutPanelCard1.TabIndex = 0;
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
            label2.Size = new Size(431, 47);
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
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(431, 127);
            label3.TabIndex = 1;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            label8.Text = "Aktivitas Terakhir Anda:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DashboardEngineerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 923);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(panelHeader);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
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
    }
}