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
    /// Logika interakcji dla klasy RegisterDealer.xaml
    /// </summary>
    public partial class RegisterDealer : Page
    {
        public RegisterDealer()
        {
            InitializeComponent();
        }


        private void RegisterDealerFn(object sender, RoutedEventArgs e)
        {
            CarDealershipAppDBEntities db = new CarDealershipAppDBEntities();

            dealer dealerObj = new dealer()
            {
                name = txtName.Text,
                surname = txtSurname.Text,
                pesel = txtPesel.Text,
                employment_date = int.Parse(txtDate.Text),

            };
            
            db.dealers.Add(dealerObj);
            db.SaveChanges();
            MessageBox.Show("Dealer registered!");
        }

        private void BackFn(object sender, RoutedEventArgs e)
        {
            var back = new Menu();
            NavigationService.Navigate(back);
        }
    }
}
