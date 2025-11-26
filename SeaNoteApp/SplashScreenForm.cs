using System;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class SplashScreenForm : Form
    {
        private int progressValue = 0;

        public SplashScreenForm()
        {
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;

            InitializeComponent();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.ForeColor = Color.PeachPuff;
            progressBar1.BackColor = Color.FromArgb(26, 52, 68);

            timer1.Interval = 30;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 1;
            progressBar1.Value = Math.Min(progressValue, 100);

            if (progressValue >= 100)
            {
                timer1.Stop();

                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;

                LoginPage loginForm = new LoginPage();
                loginForm.Show();

                this.Hide();
            }
        }
    }
}
