using SeaNoteWPF.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SeaNoteWPF
{
    public partial class DashboardEngineerWindow : Window
    {
        public DashboardEngineerWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new EngineerHomePage()); // Default Page
            SetActiveButton(NavHome);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }

        private void Nav_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            SetActiveButton(btn);

            switch (btn.Tag.ToString())
            {
                case "Home": MainFrame.Navigate(new EngineerHomePage()); break;
                case "Tasks": MainFrame.Navigate(new EngineerTaskPage()); break; // Halaman Kerja
                case "History": MessageBox.Show("History ada di Tab Completed pada menu Tasks."); break; // Gabung aja biar ringkas
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedInUser = null;
            new LoginWindow().Show();
            this.Close();
        }

        // Visual Helper
        private void SetActiveButton(Button activeBtn)
        {
            ResetBtn(NavHome); ResetBtn(NavTasks); ResetBtn(NavHistory);
            activeBtn.Background = Brushes.White;
            activeBtn.Foreground = (Brush)new BrushConverter().ConvertFrom("#0B132B");
        }
        private void ResetBtn(Button btn) { btn.Background = Brushes.Transparent; btn.Foreground = (Brush)new BrushConverter().ConvertFrom("#8D99AE"); }
    }
}