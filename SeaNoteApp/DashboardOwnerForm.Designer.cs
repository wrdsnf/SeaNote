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
            panelContent.Location = new Point(220, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(580, 450);
            panelContent.TabIndex = 3;
            // 
            // btnReportOwner
            // 
            btnReportOwner.Dock = DockStyle.Top;
            btnReportOwner.Location = new Point(0, 150);
            btnReportOwner.Name = "btnReportOwner";
            btnReportOwner.Size = new Size(580, 50);
            btnReportOwner.TabIndex = 3;
            btnReportOwner.Text = "Report Problem";
            btnReportOwner.UseVisualStyleBackColor = true;
            btnReportOwner.Click += btnReportOwner_Click;
            // 
            // btnMaintenanceViewer
            // 
            btnMaintenanceViewer.Dock = DockStyle.Top;
            btnMaintenanceViewer.Location = new Point(0, 100);
            btnMaintenanceViewer.Name = "btnMaintenanceViewer";
            btnMaintenanceViewer.Size = new Size(580, 50);
            btnMaintenanceViewer.TabIndex = 2;
            btnMaintenanceViewer.Text = "View Maintenance Record";
            btnMaintenanceViewer.UseVisualStyleBackColor = true;
            btnMaintenanceViewer.Click += btnMaintenanceViewer_Click;
            // 
            // btnShipViewer
            // 
            btnShipViewer.Dock = DockStyle.Top;
            btnShipViewer.Location = new Point(0, 50);
            btnShipViewer.Name = "btnShipViewer";
            btnShipViewer.Size = new Size(580, 50);
            btnShipViewer.TabIndex = 1;
            btnShipViewer.Text = "View Ship";
            btnShipViewer.UseVisualStyleBackColor = true;
            btnShipViewer.Click += btnShipViewer_Click;
            // 
            // btnTripViewer
            // 
            btnTripViewer.Dock = DockStyle.Top;
            btnTripViewer.Location = new Point(0, 0);
            btnTripViewer.Name = "btnTripViewer";
            btnTripViewer.Size = new Size(580, 50);
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
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 450);
            panelSidebar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(220, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(109, 36);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // DashboardOwnerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
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