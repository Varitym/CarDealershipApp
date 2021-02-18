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
    /// Logika interakcji dla klasy AddSale.xaml
    /// </summary>
    public partial class AddSale : Page
    {
        public AddSale()
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
                Console.WriteLine(item.carID);
                Console.WriteLine(item.carBrand);
                Console.WriteLine(item.carModel);
                Console.WriteLine(item.carColour);
                Console.WriteLine(item.carPrice);
                Console.WriteLine(item.carProd);
            }

            this.gridCars.ItemsSource = cars.ToList();

            var clients = from cl in db.customers
                       select new
                       {
                           customerID = cl.customer_id,
                           customerName = cl.name,
                           customerSurname = cl.surname,
                           customerCity = cl.city,
                           customerNIP = cl.nip,

                       };

            foreach (var item in cars)
            {
                Console.WriteLine(item.carBrand);
                Console.WriteLine(item.carModel);
                Console.WriteLine(item.carColour);
                Console.WriteLine(item.carPrice);
                Console.WriteLine(item.carProd);
            }

            this.gridClients.ItemsSource = clients.ToList();

            var dealers = from d in db.dealers
                       select new
                       {
                           dealersID = d.dealer_id,
                           dealersName = d.name,
                           dealersSurname = d.surname,

                       };

            foreach (var item in dealers)
            {
                Console.WriteLine(item.dealersID);
                Console.WriteLine(item.dealersName);
                Console.WriteLine(item.dealersSurname);
            }

            this.gridDealers.ItemsSource = dealers.ToList();

        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new Sale();
            NavigationService.Navigate(back);
        }

        private void AddSaleFn(object sender, RoutedEventArgs e)
        {

            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();

             var sales = from s in db.sales
                         select new
                         {
                             transactionAmountC = s.car.price,
                         };

            byte onFirm = IfOnFirm((bool)(checkCompany.IsChecked));

            sale saleObj = new sale()
            {
                customer_id = int.Parse(txtClient.Text),
                dealer_id = int.Parse(txtDealer.Text),
                car_id = int.Parse(txtCar.Text),
                transaction_amount = GetCarPrice(int.Parse(txtCar.Text), (bool)(checkCompany.IsChecked)),
                on_company = onFirm,

             };

           

            db.sales.Add(saleObj);
            db.SaveChanges();
            MessageBox.Show("Sale added");

        }

        private decimal GetCarPrice(int car_id, bool infor)
        {
            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();

            var s = from c in db.cars
                    where c.car_id == car_id
                    select c;
            
            car obj = s.SingleOrDefault();
            decimal price = obj.price;
            decimal multiplyValue = Convert.ToDecimal(0.81);

            if (infor == true)
            {
                return price * multiplyValue;
            }
            else
            {
                return price;
            }
            
        }

        

        private byte IfOnFirm(bool info)
        {
            if (info == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void ShowSalesFn(object sender, RoutedEventArgs e)
        {
            var show = new ShowSale();
            NavigationService.Navigate(show);
        }
    }
}
