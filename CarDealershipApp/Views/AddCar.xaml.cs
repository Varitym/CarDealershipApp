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
    /// Logika interakcji dla klasy AddCar.xaml
    /// </summary>
    public partial class AddCar : Page
    {

        /// <summary>
        /// Initializing WPF component for AddCar view
        /// </summary>
        public AddCar()
        {
            InitializeComponent();
        }

        private void AddCarFn(object sender, RoutedEventArgs e)
        {
            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();

            car carObj = new car()
            {
                brand = txtBrand.Text,
                model = txtModel.Text,
                colour = txtColour.Text,
                prod_date = int.Parse(txtProd.Text),
                price = decimal.Parse(txtPrice.Text),
            };

            db.cars.Add(carObj);
            db.SaveChanges();
            MessageBox.Show("Car added!");

        }

        private void ShowFn(object sender, RoutedEventArgs e)
        {
            var show = new ShowWarehouse();
            NavigationService.Navigate(show);
        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new CarManager();
            NavigationService.Navigate(back);
        }
    }
}
