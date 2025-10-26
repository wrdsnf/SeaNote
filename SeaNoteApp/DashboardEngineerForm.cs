using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class DashboardEngineerForm : Form
    {
        public DashboardEngineerForm()
        {
            InitializeComponent();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            new MaintenanceEngineerForm().Show();
        }

        private void btnMaintenanceHistory_Click(object sender, EventArgs e)
        {
            new MaintenanceHistoryEngineerForm().Show();
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
