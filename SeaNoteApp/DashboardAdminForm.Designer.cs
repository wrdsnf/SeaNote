namespace SeaNoteApp
{
    partial class DashboardAdminForm
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
            panelSidebar = new Panel();
            menuStrip1 = new MenuStrip();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panelContent = new Panel();
            btnExportReport = new Button();
            btnMaintenanceAdmin = new Button();
            btnLogManagement = new Button();
            btnTaskManagement = new Button();
            btnTripManagement = new Button();
            btnShipManagement = new Button();
            btnUserManagement = new Button();
            panelSidebar.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.DimGray;
            panelSidebar.Controls.Add(menuStrip1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(2, 2, 2, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(135, 615);
            panelSidebar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(135, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Click += logoutToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(btnUserManagement);
            panelContent.Controls.Add(btnExportReport);
            panelContent.Controls.Add(btnMaintenanceAdmin);
            panelContent.Controls.Add(btnLogManagement);
            panelContent.Controls.Add(btnTaskManagement);
            panelContent.Controls.Add(btnTripManagement);
            panelContent.Controls.Add(btnShipManagement);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(135, 0);
            panelContent.Margin = new Padding(2, 2, 2, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(357, 615);
            panelContent.TabIndex = 1;
            // 
            // btnExportReport
            // 
            btnExportReport.Dock = DockStyle.Top;
            btnExportReport.Location = new Point(0, 420);
            btnExportReport.Margin = new Padding(2, 2, 2, 2);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(357, 84);
            btnExportReport.TabIndex = 5;
            btnExportReport.Text = "Export Reports";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // btnMaintenanceAdmin
            // 
            btnMaintenanceAdmin.Dock = DockStyle.Top;
            btnMaintenanceAdmin.Location = new Point(0, 336);
            btnMaintenanceAdmin.Margin = new Padding(2, 2, 2, 2);
            btnMaintenanceAdmin.Name = "btnMaintenanceAdmin";
            btnMaintenanceAdmin.Size = new Size(357, 84);
            btnMaintenanceAdmin.TabIndex = 4;
            btnMaintenanceAdmin.Text = "Manage Maintenance";
            btnMaintenanceAdmin.UseVisualStyleBackColor = true;
            btnMaintenanceAdmin.Click += btnMaintenanceAdmin_Click;
            // 
            // btnLogManagement
            // 
            btnLogManagement.Dock = DockStyle.Top;
            btnLogManagement.Location = new Point(0, 252);
            btnLogManagement.Margin = new Padding(2, 2, 2, 2);
            btnLogManagement.Name = "btnLogManagement";
            btnLogManagement.Size = new Size(357, 84);
            btnLogManagement.TabIndex = 3;
            btnLogManagement.Text = "Manage Logs";
            btnLogManagement.UseVisualStyleBackColor = true;
            btnLogManagement.Click += btnLogManagement_Click;
            // 
            // btnTaskManagement
            // 
            btnTaskManagement.Dock = DockStyle.Top;
            btnTaskManagement.Location = new Point(0, 168);
            btnTaskManagement.Margin = new Padding(2, 2, 2, 2);
            btnTaskManagement.Name = "btnTaskManagement";
            btnTaskManagement.Size = new Size(357, 84);
            btnTaskManagement.TabIndex = 2;
            btnTaskManagement.Text = "Manage Tasks";
            btnTaskManagement.UseVisualStyleBackColor = true;
            btnTaskManagement.Click += btnTaskManagement_Click;
            // 
            // btnTripManagement
            // 
            btnTripManagement.Dock = DockStyle.Top;
            btnTripManagement.Location = new Point(0, 84);
            btnTripManagement.Margin = new Padding(2, 2, 2, 2);
            btnTripManagement.Name = "btnTripManagement";
            btnTripManagement.Size = new Size(357, 84);
            btnTripManagement.TabIndex = 1;
            btnTripManagement.Text = "Manage Trips";
            btnTripManagement.UseVisualStyleBackColor = true;
            btnTripManagement.Click += btnTripManagement_Click;
            // 
            // btnShipManagement
            // 
            btnShipManagement.Dock = DockStyle.Top;
            btnShipManagement.Location = new Point(0, 0);
            btnShipManagement.Margin = new Padding(2, 2, 2, 2);
            btnShipManagement.Name = "btnShipManagement";
            btnShipManagement.Size = new Size(357, 84);
            btnShipManagement.TabIndex = 0;
            btnShipManagement.Text = "Manage Ships";
            btnShipManagement.UseVisualStyleBackColor = true;
            btnShipManagement.Click += btnShipManagement_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Dock = DockStyle.Top;
            btnUserManagement.Location = new Point(0, 504);
            btnUserManagement.Margin = new Padding(2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(357, 84);
            btnUserManagement.TabIndex = 6;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // DashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(492, 615);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "DashboardAdminForm";
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelContent;
        private Button btnExportReport;
        private Button btnMaintenanceAdmin;
        private Button btnLogManagement;
        private Button btnTaskManagement;
        private Button btnTripManagement;
        private Button btnShipManagement;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Button btnUserManagement;
    }
}