namespace SeaNoteApp
{
    partial class DashboardEngineerForm
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
            btnMaintenanceHistory = new Button();
            btnMaintenance = new Button();
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
            panelContent.Controls.Add(btnMaintenanceHistory);
            panelContent.Controls.Add(btnMaintenance);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(580, 450);
            panelContent.TabIndex = 3;
            // 
            // btnMaintenanceHistory
            // 
            btnMaintenanceHistory.Dock = DockStyle.Top;
            btnMaintenanceHistory.Location = new Point(0, 135);
            btnMaintenanceHistory.Name = "btnMaintenanceHistory";
            btnMaintenanceHistory.Size = new Size(580, 135);
            btnMaintenanceHistory.TabIndex = 5;
            btnMaintenanceHistory.Text = "Maintenance History";
            btnMaintenanceHistory.UseVisualStyleBackColor = true;
            btnMaintenanceHistory.Click += btnMaintenanceHistory_Click;
            // 
            // btnMaintenance
            // 
            btnMaintenance.Dock = DockStyle.Top;
            btnMaintenance.Location = new Point(0, 0);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(580, 135);
            btnMaintenance.TabIndex = 4;
            btnMaintenance.Text = "Maintenance Management";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
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
            menuStrip1.Size = new Size(220, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Click += logoutToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(109, 36);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // DashboardEngineerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "DashboardEngineerForm";
            Text = "Engineer Dashboard";
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
        private Button btnMaintenanceHistory;
        private Button btnMaintenance;
        private Panel panelSidebar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}