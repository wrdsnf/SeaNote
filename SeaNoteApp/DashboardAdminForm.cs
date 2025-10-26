using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
        }

        private void btnShipManagement_Click(object sender, EventArgs e)
        {
            new ShipManagementForm().Show();
        }

        private void btnTripManagement_Click(object sender, EventArgs e)
        {
            new TripManagementForm().Show();
        }

        private void btnTaskManagement_Click(object sender, EventArgs e)
        {
            new TaskManagementForm().Show();
        }

        private void btnLogManagement_Click(object sender, EventArgs e)
        {
            new LogManagementForm().Show();
        }

        private void btnMaintenanceAdmin_Click(object sender, EventArgs e)
        {
            new MaintenanceAdminForm().Show();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            new ExportReportForm().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginForm = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                new LoginPage().Show();
            }
            this.Close();
        }
    }
}