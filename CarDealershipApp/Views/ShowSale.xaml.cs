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
    /// Logika interakcji dla klasy ShowSale.xaml
    /// </summary>
    public partial class ShowSale : Page
    {
        public ShowSale()
        {
            InitializeComponent();
            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();
            var sales = from s in db.sales
                        select new
                        {
                            customerName = s.customer.name,
                            customerSurname = s.customer.surname,
                            carBrand = s.car.brand,
                            carModel = s.car.model,
                            carColour = s.car.colour,
                            carProd = s.car.prod_date,
                            transactionAmount = s.transaction_amount,
                            onCompany = s.on_company,
                            dealerID = s.dealer.dealer_id,

                       };

            foreach (var item in sales)
            {
                Console.WriteLine(item.customerName);
                Console.WriteLine(item.customerSurname);
                Console.WriteLine(item.carBrand);
                Console.WriteLine(item.carColour);
                Console.WriteLine(item.transactionAmount);
                Console.WriteLine(item.onCompany);
                Console.WriteLine(item.dealerID);
            }

            this.gridSales.ItemsSource = sales.ToList();
        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new Sale();
            NavigationService.Navigate(back);
        }

     
    }
}
