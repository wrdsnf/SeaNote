using SeaNote.Models;
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
            if (LoginPage.loggedInUser != null)
            {
                this.Text = "Admin Dashboard (" + LoginPage.loggedInUser.Username + ")";
            }
        }

        private void BtnShipManagement_Click(object sender, EventArgs e)
        {
            new ShipManagementForm().Show();
        }

        private void BtnTripManagement_Click(object sender, EventArgs e)
        {
            new TripManagementForm().Show();
        }


        private void BtnMaintenanceAdmin_Click(object sender, EventArgs e)
        {
            new MaintenanceAdminForm().Show();
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            new UserManagementForm().Show();
        }

        private void BtnExportReport_Click(object sender, EventArgs e)
        {
            new ExportReportForm().Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage.loggedInUser = null;
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

        private void btnTestPoli_Click(object sender, EventArgs e)
        {
            List<ReportableBase> kantongAjaib = new List<ReportableBase>();

            kantongAjaib.Add(new Ship { Name = "KM. Jaya", Year = 2020 });
            kantongAjaib.Add(new Trip { TitikBerangkat = "Surabaya", Nakhoda = "Budi" });

            string fullReport = "";

            foreach (var item in kantongAjaib)
            {
                fullReport += item.GetSummary() + "\n";
            }

            MessageBox.Show(fullReport);
        }
    }
    
}