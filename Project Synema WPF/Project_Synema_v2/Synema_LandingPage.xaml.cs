using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Synema_v2
{
    /// <summary>
    /// Interaction logic for Synema_LandingPage.xaml
    /// </summary>
    public partial class Synema_LandingPage : Page
    {
        public Synema_LandingPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Synema_Home Synema_Home = new Synema_Home();
            this.NavigationService.Navigate(Synema_Home);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Synema_Registration Synema_Registration = new Synema_Registration();
            this.NavigationService.Navigate(Synema_Registration);
        }
    }
}
