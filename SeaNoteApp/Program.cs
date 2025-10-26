using System;
using System.Windows.Forms;

namespace SeaNoteApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Jalankan LoginPage
            Application.Run(new LoginPage());
        }
    }
}
