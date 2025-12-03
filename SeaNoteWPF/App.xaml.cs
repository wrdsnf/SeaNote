using System.Configuration;
using System.Data;
using System.Windows;
using SeaNote.Models;

namespace SeaNoteWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User? LoggedInUser { get; set; }
    }

}
