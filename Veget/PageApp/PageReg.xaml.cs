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
using Veget.ADOApp;

namespace Veget.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ClEventRegistration(object sender, RoutedEventArgs e)
        {
            try
            {

            Users newUser = new Users()
            {
                Name = TxtName.Text,
                Login = TxtLogin.Text,
                Password = TxtPassword.Password,
                RoleId = 4
            };
            App.Connection.Users.Add(newUser);
            App.Connection.SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            MessageBox.Show("Регистрация прошла успешно","Информация",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
