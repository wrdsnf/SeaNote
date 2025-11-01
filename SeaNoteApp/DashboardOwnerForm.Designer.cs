namespace SeaNoteApp
{
    partial class DashboardOwnerForm
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
            btnShipViewer = new Button();
            btnTripViewer = new Button();
            btnMaintenanceViewer = new Button();
            btnReportOwner = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(713, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 38);
            fileToolStripMenuItem.Text = "...";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(359, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(93, 85);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(583, 72);
            label1.TabIndex = 1;
            label1.Text = "OWNER DASHBOARD";
            // 
            // btnShipViewer
            // 
            btnShipViewer.Location = new Point(186, 213);
            btnShipViewer.Margin = new Padding(6, 6, 6, 6);
            btnShipViewer.Name = "btnShipViewer";
            btnShipViewer.Size = new Size(334, 85);
            btnShipViewer.TabIndex = 2;
            btnShipViewer.Text = "View Ships";
            btnShipViewer.UseVisualStyleBackColor = true;
            btnShipViewer.Click += BtnShipViewer_Click;
            // 
            // btnTripViewer
            // 
            btnTripViewer.Location = new Point(186, 320);
            btnTripViewer.Margin = new Padding(6, 6, 6, 6);
            btnTripViewer.Name = "btnTripViewer";
            btnTripViewer.Size = new Size(334, 85);
            btnTripViewer.TabIndex = 3;
            btnTripViewer.Text = "View Trips";
            btnTripViewer.UseVisualStyleBackColor = true;
            btnTripViewer.Click += BtnTripViewer_Click;
            // 
            // btnMaintenanceViewer
            // 
            btnMaintenanceViewer.Location = new Point(186, 427);
            btnMaintenanceViewer.Margin = new Padding(6, 6, 6, 6);
            btnMaintenanceViewer.Name = "btnMaintenanceViewer";
            btnMaintenanceViewer.Size = new Size(334, 85);
            btnMaintenanceViewer.TabIndex = 4;
            btnMaintenanceViewer.Text = "View Maintenance";
            btnMaintenanceViewer.UseVisualStyleBackColor = true;
            btnMaintenanceViewer.Click += BtnMaintenanceViewer_Click;
            // 
            // btnReportOwner
            // 
            btnReportOwner.Location = new Point(186, 533);
            btnReportOwner.Margin = new Padding(6, 6, 6, 6);
            btnReportOwner.Name = "btnReportOwner";
            btnReportOwner.Size = new Size(334, 85);
            btnReportOwner.TabIndex = 5;
            btnReportOwner.Text = "View Reports";
            btnReportOwner.UseVisualStyleBackColor = true;
            btnReportOwner.Click += BtnReportOwner_Click;
            // 
            // DashboardOwnerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 685);
            Controls.Add(btnReportOwner);
            Controls.Add(btnMaintenanceViewer);
            Controls.Add(btnTripViewer);
            Controls.Add(btnShipViewer);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            Name = "DashboardOwnerForm";
            Text = "Owner Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShipViewer;
        private System.Windows.Forms.Button btnTripViewer;
        private System.Windows.Forms.Button btnMaintenanceViewer;
        private System.Windows.Forms.Button btnReportOwner;
    }
}