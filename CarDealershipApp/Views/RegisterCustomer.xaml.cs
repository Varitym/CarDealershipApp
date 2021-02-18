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
    /// Logika interakcji dla klasy RegisterCustomer.xaml
    /// </summary>
    public partial class RegisterCustomer : Page
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void RegisterCustomerFn(object sender, RoutedEventArgs e)
        {
            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();

            customer customerObj = new customer()
            {
                name = txtName.Text,
                surname = txtSurname.Text,
                pesel = txtPesel.Text,
                nip = txtNip.Text,
                city = txtCity.Text,

            };

            db.customers.Add(customerObj);
            db.SaveChanges();
            MessageBox.Show("Customer registered!");
        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new Menu();
            NavigationService.Navigate(back);
        }
    }
}
