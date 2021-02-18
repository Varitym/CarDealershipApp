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
    /// Logika interakcji dla klasy DeleteCar.xaml
    /// </summary>
    public partial class DeleteCar : Page
    {
        public DeleteCar()
        {
            InitializeComponent();
            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();
            var cars = from c in db.cars
                       select new
                       {
                           carID = c.car_id,
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

        private int cid = 0;
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (this.gridCars.SelectedIndex >= 0) {
                {
                    
                    if (this.gridCars.SelectedItems.Count >= 0)
                    {

                        dynamic row = this.gridCars.SelectedItems[0];
                        this.cid = row.carID;
                                                           
                   }
                }
            }   
        }


        private void DelBtn(object sender, RoutedEventArgs e)
        {
            

            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();
            var s = from c in db.cars
                    where c.car_id == this.cid
                    select c;

            car obj = s.SingleOrDefault();

            if(obj != null)
            {
                db.cars.Remove(obj);
                db.SaveChanges();
            }



        }

        private void RefreshFn(object sender, RoutedEventArgs e)
        {
            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();
            this.gridCars.ItemsSource = db.cars.ToList();
        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new CarManager();
            NavigationService.Navigate(back);
        }
    }
}
