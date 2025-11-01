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
            if (LoginPage.loggedInUser != null)
            {
                this.Text = "Owner Dashboard (" + LoginPage.loggedInUser.Username + ")";
            }
        }

        private void BtnShipViewer_Click(object sender, EventArgs e)
        {
            new ShipViewerForm().Show();
        }

        private void BtnTripViewer_Click(object sender, EventArgs e)
        {
            new TripViewerForm().Show();
        }

        private void BtnMaintenanceViewer_Click(object sender, EventArgs e)
        {
            new MaintenanceViewerOwnerForm().Show();
        }

        private void BtnReportOwner_Click(object sender, EventArgs e)
        {
            new ReportOwnerForm().Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage.loggedInUser = null;
            var loginForm = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            if (loginForm != null) { loginForm.Show(); } else { new LoginPage().Show(); }
            this.Close();
        }
    }
}