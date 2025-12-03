using SeaNoteWPF.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SeaNoteWPF
{
    public partial class DashboardOwnerWindow : Window
    {
        public DashboardOwnerWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new OwnerHomePage());
            SetActiveButton(NavHome);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }

        private void Nav_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            SetActiveButton(btn);
            switch (btn.Tag.ToString())
            {
                case "Home": MainFrame.Navigate(new OwnerHomePage()); break;
                case "Ships": MainFrame.Navigate(new OwnerShipPage()); break;
                case "Trips": MainFrame.Navigate(new OwnerTripPage()); break;
                case "Maint": MainFrame.Navigate(new OwnerMaintenancePage()); break;
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e) { App.LoggedInUser = null; new LoginWindow().Show(); this.Close(); }

        private void SetActiveButton(Button activeBtn)
        {
            // Reset 4 tombol ini
            ResetBtn(NavHome);
            ResetBtn(NavShips);
            ResetBtn(NavTrips);
            //ResetBtn(NavMaint); // Sekarang XAML udah punya nama ini, jadi gak error lagi

            // Highlight tombol aktif
            if (activeBtn != null)
            {
                activeBtn.Background = Brushes.White;
                activeBtn.Foreground = (Brush)new BrushConverter().ConvertFrom("#0B132B");
            }
        }
        private void ResetBtn(Button btn) { btn.Background = Brushes.Transparent; btn.Foreground = (Brush)new BrushConverter().ConvertFrom("#8D99AE"); }
    }
}