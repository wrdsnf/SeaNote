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
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panelContent = new Panel();
            btnExportReport = new Button();
            btnMaintenanceAdmin = new Button();
            btnLogManagement = new Button();
            btnTaskManagement = new Button();
            btnTripManagement = new Button();
            btnShipManagement = new Button();
            panelSidebar.SuspendLayout();
            menuStrip2.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.DimGray;
            panelSidebar.Controls.Add(menuStrip2);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(2, 1, 2, 1);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(118, 414);
            panelSidebar.TabIndex = 0;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(3, 1, 0, 1);
            menuStrip2.Size = new Size(118, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 22);
            toolStripMenuItem1.Text = "Logout";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(btnExportReport);
            panelContent.Controls.Add(btnMaintenanceAdmin);
            panelContent.Controls.Add(btnLogManagement);
            panelContent.Controls.Add(btnTaskManagement);
            panelContent.Controls.Add(btnTripManagement);
            panelContent.Controls.Add(btnShipManagement);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(118, 0);
            panelContent.Margin = new Padding(2, 1, 2, 1);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(313, 414);
            panelContent.TabIndex = 1;
            // 
            // btnExportReport
            // 
            btnExportReport.Dock = DockStyle.Top;
            btnExportReport.Location = new Point(0, 315);
            btnExportReport.Margin = new Padding(2, 1, 2, 1);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(313, 63);
            btnExportReport.TabIndex = 5;
            btnExportReport.Text = "Export Reports";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // btnMaintenanceAdmin
            // 
            btnMaintenanceAdmin.Dock = DockStyle.Top;
            btnMaintenanceAdmin.Location = new Point(0, 252);
            btnMaintenanceAdmin.Margin = new Padding(2, 1, 2, 1);
            btnMaintenanceAdmin.Name = "btnMaintenanceAdmin";
            btnMaintenanceAdmin.Size = new Size(313, 63);
            btnMaintenanceAdmin.TabIndex = 4;
            btnMaintenanceAdmin.Text = "Manage Maintenance";
            btnMaintenanceAdmin.UseVisualStyleBackColor = true;
            btnMaintenanceAdmin.Click += btnMaintenanceAdmin_Click;
            // 
            // btnLogManagement
            // 
            btnLogManagement.Dock = DockStyle.Top;
            btnLogManagement.Location = new Point(0, 189);
            btnLogManagement.Margin = new Padding(2, 1, 2, 1);
            btnLogManagement.Name = "btnLogManagement";
            btnLogManagement.Size = new Size(313, 63);
            btnLogManagement.TabIndex = 3;
            btnLogManagement.Text = "Manage Logs";
            btnLogManagement.UseVisualStyleBackColor = true;
            btnLogManagement.Click += btnLogManagement_Click;
            // 
            // btnTaskManagement
            // 
            btnTaskManagement.Dock = DockStyle.Top;
            btnTaskManagement.Location = new Point(0, 126);
            btnTaskManagement.Margin = new Padding(2, 1, 2, 1);
            btnTaskManagement.Name = "btnTaskManagement";
            btnTaskManagement.Size = new Size(313, 63);
            btnTaskManagement.TabIndex = 2;
            btnTaskManagement.Text = "Manage Tasks";
            btnTaskManagement.UseVisualStyleBackColor = true;
            btnTaskManagement.Click += btnTaskManagement_Click;
            // 
            // btnTripManagement
            // 
            btnTripManagement.Dock = DockStyle.Top;
            btnTripManagement.Location = new Point(0, 63);
            btnTripManagement.Margin = new Padding(2, 1, 2, 1);
            btnTripManagement.Name = "btnTripManagement";
            btnTripManagement.Size = new Size(313, 63);
            btnTripManagement.TabIndex = 1;
            btnTripManagement.Text = "Manage Trips";
            btnTripManagement.UseVisualStyleBackColor = true;
            btnTripManagement.Click += btnTripManagement_Click;
            // 
            // btnShipManagement
            // 
            btnShipManagement.Dock = DockStyle.Top;
            btnShipManagement.Location = new Point(0, 0);
            btnShipManagement.Margin = new Padding(2, 1, 2, 1);
            btnShipManagement.Name = "btnShipManagement";
            btnShipManagement.Size = new Size(313, 63);
            btnShipManagement.TabIndex = 0;
            btnShipManagement.Text = "Manage Ships";
            btnShipManagement.UseVisualStyleBackColor = true;
            btnShipManagement.Click += btnShipManagement_Click;
            // 
            // DashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 414);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DashboardAdminForm";
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}