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
using Veget.ClassApp;

namespace Veget.PageApp.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageMenuAdmin.xaml
    /// </summary>
    public partial class PageMenuAdmin : Page
    {
        public PageMenuAdmin()
        {
            InitializeComponent();
        }

        private void ClEventGoBack(object sender, RoutedEventArgs e)
        {
            if (ClassMessage.ResultMess("Вы уверенны, что хотите выйти?") == MessageBoxResult.Yes)
            {
                NavigationService.GoBack();
            }    
        }

        private void ClEvenShowUser(object sender, RoutedEventArgs e)
        {
            MainAdminFrame.NavigationService.Navigate(new PageAdmin.PageShowUser());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainAdminFrame.NavigationService.Navigate(new PageAdmin.PageAddVeget());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainAdminFrame.NavigationService.Navigate(new PageAdmin.PageAddSal());
        }

    }
}
