using SeaNoteWPF.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SeaNoteWPF
{
    public partial class DashboardAdminWindow : Window
    {
        public DashboardAdminWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AdminHomePage()); // Default ke Home
            SetActiveButton(NavHome);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.MaxHeight = SystemParameters.WorkArea.Height;
        }

        private void Nav_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            SetActiveButton(btn);
            switch (btn.Tag.ToString())
            {
                case "Home": MainFrame.Navigate(new AdminHomePage()); break;
                case "Ships": MainFrame.Navigate(new ShipPage()); break;
                case "Trips": MainFrame.Navigate(new TripPage()); break;
                case "Users": MainFrame.Navigate(new UserPage()); break;
                case "Maint": MainFrame.Navigate(new MaintenancePage()); break;
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedInUser = null;
            new LoginWindow().Show();
            this.Close();
        }

        private void BtnCloseApp_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        private void SetActiveButton(Button activeBtn)
        {
            ResetBtn(NavHome); ResetBtn(NavShips); ResetBtn(NavTrips); ResetBtn(NavMaint); ResetBtn(NavUsers);
            if (activeBtn != null)
            {
                activeBtn.Background = Brushes.White;
                activeBtn.Foreground = (Brush)new BrushConverter().ConvertFrom("#0B132B");
            }
        }
        private void ResetBtn(Button btn)
        {
            if (btn != null)
            {
                btn.Background = Brushes.Transparent;
                btn.Foreground = (Brush)new BrushConverter().ConvertFrom("#8D99AE");
            }
        }
    }
}