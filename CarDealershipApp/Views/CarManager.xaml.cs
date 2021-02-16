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
    /// Logika interakcji dla klasy CarManager.xaml
    /// </summary>
    public partial class CarManager : Page
    {
        public CarManager()
        {
            InitializeComponent();
            

        }

        private void AddCarF(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCarF(object sender, RoutedEventArgs e)
        {
            var del = new DeleteCar();
            NavigationService.Navigate(del);
        }

        private void ShowWarehouseF(object sender, RoutedEventArgs e)
        {
            var show = new ShowWarehouse();
            NavigationService.Navigate(show);
        }

        private void BackF(object sender, RoutedEventArgs e)
        {
            var back = new Menu();
            NavigationService.Navigate(back);
        }

        private void AddFn(object sender, RoutedEventArgs e)
        {
            var add = new AddCar();
            NavigationService.Navigate(add);
        }
    }
}
