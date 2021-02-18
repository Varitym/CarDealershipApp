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
    /// Logika interakcji dla klasy ShowWarehouse.xaml
    /// </summary>
    public partial class ShowWarehouse : Page
    {
        /// <summary>
        /// Initializng WPF component and after it connecting to base and showing grid with records from DB
        /// </summary>
        
    
        public ShowWarehouse()
        {
            InitializeComponent();
            

            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();
            var cars = from c in db.cars
                       select new
                       {
                           carBrand = c.brand,
                           carModel = c.model,
                           carPrice = c.price,
                           carColour = c.colour,
                           carProd = c.prod_date
                       };

            foreach (var item in cars)
            {
                Console.WriteLine(item.carBrand);
                Console.WriteLine(item.carModel);
                Console.WriteLine(item.carColour);
                Console.WriteLine(item.carPrice);
                Console.WriteLine(item.carProd);
            }

            this.gridCars.ItemsSource = cars.ToList();
        }

        private void BackF(object sender, RoutedEventArgs e)
        {
            var back = new CarManager();
            NavigationService.Navigate(back);
        }
    }
}
