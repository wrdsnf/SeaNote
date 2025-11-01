namespace SeaNoteApp
{
    partial class DashboardOwnerForm
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
            panelContent = new Panel();
            btnReportOwner = new Button();
            btnMaintenanceViewer = new Button();
            btnShipViewer = new Button();
            btnTripViewer = new Button();
            panelSidebar = new Panel();
            menuStrip1 = new MenuStrip();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panelContent.SuspendLayout();
            panelSidebar.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Controls.Add(btnReportOwner);
            panelContent.Controls.Add(btnMaintenanceViewer);
            panelContent.Controls.Add(btnShipViewer);
            panelContent.Controls.Add(btnTripViewer);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(118, 0);
            panelContent.Margin = new Padding(2, 1, 2, 1);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(313, 266);
            panelContent.TabIndex = 3;
            // 
            // btnReportOwner
            // 
            btnReportOwner.Dock = DockStyle.Top;
            btnReportOwner.Location = new Point(0, 189);
            btnReportOwner.Margin = new Padding(2, 1, 2, 1);
            btnReportOwner.Name = "btnReportOwner";
            btnReportOwner.Size = new Size(313, 63);
            btnReportOwner.TabIndex = 3;
            btnReportOwner.Text = "Report Problem";
            btnReportOwner.UseVisualStyleBackColor = true;
            btnReportOwner.Click += btnReportOwner_Click;
            // 
            // btnMaintenanceViewer
            // 
            btnMaintenanceViewer.Dock = DockStyle.Top;
            btnMaintenanceViewer.Location = new Point(0, 126);
            btnMaintenanceViewer.Margin = new Padding(2, 1, 2, 1);
            btnMaintenanceViewer.Name = "btnMaintenanceViewer";
            btnMaintenanceViewer.Size = new Size(313, 63);
            btnMaintenanceViewer.TabIndex = 2;
            btnMaintenanceViewer.Text = "View Maintenance Record";
            btnMaintenanceViewer.UseVisualStyleBackColor = true;
            btnMaintenanceViewer.Click += btnMaintenanceViewer_Click;
            // 
            // btnShipViewer
            // 
            btnShipViewer.Dock = DockStyle.Top;
            btnShipViewer.Location = new Point(0, 63);
            btnShipViewer.Margin = new Padding(2, 1, 2, 1);
            btnShipViewer.Name = "btnShipViewer";
            btnShipViewer.Size = new Size(313, 63);
            btnShipViewer.TabIndex = 1;
            btnShipViewer.Text = "View Ship";
            btnShipViewer.UseVisualStyleBackColor = true;
            btnShipViewer.Click += btnShipViewer_Click;
            // 
            // btnTripViewer
            // 
            btnTripViewer.Dock = DockStyle.Top;
            btnTripViewer.Location = new Point(0, 0);
            btnTripViewer.Margin = new Padding(2, 1, 2, 1);
            btnTripViewer.Name = "btnTripViewer";
            btnTripViewer.Size = new Size(313, 63);
            btnTripViewer.TabIndex = 0;
            btnTripViewer.Text = "View All Trips";
            btnTripViewer.UseVisualStyleBackColor = true;
            btnTripViewer.Click += btnTripViewer_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.DimGray;
            panelSidebar.Controls.Add(menuStrip1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(2, 1, 2, 1);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(118, 266);
            panelSidebar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(118, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Click += logoutToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // DashboardOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 266);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DashboardOwnerForm";
            Text = "Owner Dashboard";
            WindowState = FormWindowState.Maximized;
            panelContent.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Button btnReportOwner;
        private Button btnMaintenanceViewer;
        private Button btnShipViewer;
        private Button btnTripViewer;
        private Panel panelSidebar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}