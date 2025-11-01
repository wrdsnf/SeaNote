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
            btnMaintenanceHistory = new Button();
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
            label1.Location = new Point(74, 85);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(644, 72);
            label1.TabIndex = 1;
            label1.Text = "ENGINEER DASHBOARD";
            // 
            // btnMaintenanceEngineer
            // 
            btnMaintenanceEngineer.Location = new Point(186, 213);
            btnMaintenanceEngineer.Margin = new Padding(6, 6, 6, 6);
            btnMaintenanceEngineer.Name = "btnMaintenanceEngineer";
            btnMaintenanceEngineer.Size = new Size(334, 85);
            btnMaintenanceEngineer.TabIndex = 2;
            btnMaintenanceEngineer.Text = "Manage Maintenance";
            btnMaintenanceEngineer.UseVisualStyleBackColor = true;
            btnMaintenanceEngineer.Click += BtnMaintenanceEngineer_Click;
            // 
            // btnMaintenanceHistory
            // 
            btnMaintenanceHistory.Location = new Point(186, 320);
            btnMaintenanceHistory.Margin = new Padding(6, 6, 6, 6);
            btnMaintenanceHistory.Name = "btnMaintenanceHistory";
            btnMaintenanceHistory.Size = new Size(334, 85);
            btnMaintenanceHistory.TabIndex = 3;
            btnMaintenanceHistory.Text = "View History";
            btnMaintenanceHistory.UseVisualStyleBackColor = true;
            btnMaintenanceHistory.Click += BtnMaintenanceHistory_Click;
            // 
            // DashboardEngineerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 471);
            Controls.Add(btnMaintenanceHistory);
            Controls.Add(btnMaintenanceEngineer);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            Name = "DashboardEngineerForm";
            Text = "Engineer Dashboard";
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
        private System.Windows.Forms.Button btnMaintenanceEngineer;
        private System.Windows.Forms.Button btnMaintenanceHistory;
    }
}