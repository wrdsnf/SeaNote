using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class DashboardOwnerForm : Form
    {
        public DashboardOwnerForm()
        {
            InitializeComponent();
        }

        private void btnTripViewer_Click(object sender, EventArgs e)
        {
            new TripViewerForm().Show();
        }

        private void btnShipViewer_Click(object sender, EventArgs e)
        {
            new ShipViewerForm().Show();
        }

        private void btnMaintenanceViewer_Click(object sender, EventArgs e)
        {
            new MaintenanceViewerOwnerForm().Show();
        }

        private void btnReportOwner_Click(object sender, EventArgs e)
        {
            new ReportOwnerForm().Show();
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
