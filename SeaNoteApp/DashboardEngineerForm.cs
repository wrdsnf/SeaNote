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
            if (LoginPage.loggedInUser != null)
            {
                this.Text = "Engineer Dashboard (" + LoginPage.loggedInUser.Username + ")";
            }
        }

        private void BtnMaintenanceEngineer_Click(object sender, EventArgs e)
        {
            new MaintenanceEngineerForm().Show();
        }

        private void BtnMaintenanceHistory_Click(object sender, EventArgs e)
        {
            new MaintenanceHistoryEngineerForm().Show();
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