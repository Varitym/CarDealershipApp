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

namespace CarDealershipApp.Views
{
    /// <summary>
    /// Logika interakcji dla klasy RegisterMenu.xaml
    /// </summary>
    public partial class RegisterMenu : Page
    {
        public RegisterMenu()
        {
            InitializeComponent();
        }

        private void RegCustomerFn(object sender, RoutedEventArgs e)
        {
            var regC = new RegisterCustomer();
            NavigationService.Navigate(regC);
        }

        private void RegDealerFn(object sender, RoutedEventArgs e)
        {
            var regD = new RegisterDealer();
            NavigationService.Navigate(regD);
        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new Menu();
            NavigationService.Navigate(back);
        }
    }
}
    

