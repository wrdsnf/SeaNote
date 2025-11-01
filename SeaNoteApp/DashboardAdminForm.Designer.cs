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
            btnShipManagement = new Button();
            btnTripManagement = new Button();
            btnMaintenanceAdmin = new Button();
            btnUserManagement = new Button();
            btnExportReport = new Button();
            btnTestPoli = new Button();
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
            menuStrip1.Size = new Size(899, 44);
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
            logoutToolStripMenuItem.Size = new Size(359, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(204, 85);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(571, 72);
            label1.TabIndex = 1;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // btnShipManagement
            // 
            btnShipManagement.Location = new Point(74, 213);
            btnShipManagement.Margin = new Padding(6);
            btnShipManagement.Name = "btnShipManagement";
            btnShipManagement.Size = new Size(334, 85);
            btnShipManagement.TabIndex = 2;
            btnShipManagement.Text = "Manage Ships";
            btnShipManagement.UseVisualStyleBackColor = true;
            btnShipManagement.Click += BtnShipManagement_Click;
            // 
            // btnTripManagement
            // 
            btnTripManagement.Location = new Point(74, 320);
            btnTripManagement.Margin = new Padding(6);
            btnTripManagement.Name = "btnTripManagement";
            btnTripManagement.Size = new Size(334, 85);
            btnTripManagement.TabIndex = 3;
            btnTripManagement.Text = "Manage Trips";
            btnTripManagement.UseVisualStyleBackColor = true;
            btnTripManagement.Click += BtnTripManagement_Click;
            // 
            // btnMaintenanceAdmin
            // 
            btnMaintenanceAdmin.Location = new Point(483, 213);
            btnMaintenanceAdmin.Margin = new Padding(6);
            btnMaintenanceAdmin.Name = "btnMaintenanceAdmin";
            btnMaintenanceAdmin.Size = new Size(334, 85);
            btnMaintenanceAdmin.TabIndex = 6;
            btnMaintenanceAdmin.Text = "Manage Maintenance";
            btnMaintenanceAdmin.UseVisualStyleBackColor = true;
            btnMaintenanceAdmin.Click += BtnMaintenanceAdmin_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Location = new Point(483, 320);
            btnUserManagement.Margin = new Padding(6);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(334, 85);
            btnUserManagement.TabIndex = 7;
            btnUserManagement.Text = "Manage Users";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += BtnUserManagement_Click;
            // 
            // btnExportReport
            // 
            btnExportReport.Location = new Point(279, 469);
            btnExportReport.Margin = new Padding(6);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(334, 85);
            btnExportReport.TabIndex = 8;
            btnExportReport.Text = "Export Reports";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += BtnExportReport_Click;
            // 
            // btnTestPoli
            // 
            btnTestPoli.BackColor = SystemColors.ActiveCaption;
            btnTestPoli.FlatStyle = FlatStyle.Flat;
            btnTestPoli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTestPoli.ForeColor = Color.White;
            btnTestPoli.Location = new Point(667, 508);
            btnTestPoli.Name = "btnTestPoli";
            btnTestPoli.Size = new Size(150, 46);
            btnTestPoli.TabIndex = 9;
            btnTestPoli.Text = "Poly Test";
            btnTestPoli.UseVisualStyleBackColor = false;
            btnTestPoli.Click += btnTestPoli_Click;
            // 
            // DashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 599);
            Controls.Add(btnTestPoli);
            Controls.Add(btnExportReport);
            Controls.Add(btnUserManagement);
            Controls.Add(btnMaintenanceAdmin);
            Controls.Add(btnTripManagement);
            Controls.Add(btnShipManagement);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "DashboardAdminForm";
            Text = "Admin Dashboard";
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
        private System.Windows.Forms.Button btnShipManagement;
        private System.Windows.Forms.Button btnTripManagement;
        private System.Windows.Forms.Button btnMaintenanceAdmin;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnExportReport;
        private Button btnTestPoli;
    }
}