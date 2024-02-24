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

namespace Veget.PageApp.PageAgroomist
{
    /// <summary>
    /// Логика взаимодействия для PageMenuAgro.xaml
    /// </summary>
    public partial class PageMenuAgro : Page
    {
        public PageMenuAgro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ClassMessage.ResultMess("Вы уверенны, что хотите выйти?") == MessageBoxResult.Yes)
            {
                NavigationService.GoBack();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainAgroFrame.NavigationService.Navigate(new PageAgroomist.PageShowVeget());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainAgroFrame.NavigationService.Navigate(new PageAgroomist.PageCreateVeget());

        }
    }
}
