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
    /// Logika interakcji dla klasy Sale.xaml
    /// </summary>
    public partial class Sale : Page
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void AddSaleFn(object sender, RoutedEventArgs e)
        {
            var add = new AddSale();
            NavigationService.Navigate(add);
        }

        private void SalesListFn(object sender, RoutedEventArgs e)
        {
            var slist = new ShowSale();
            NavigationService.Navigate(slist);
        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new Menu();
            NavigationService.Navigate(back);
        }
    }
}
