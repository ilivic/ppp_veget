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

namespace Veget.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageSalerMenu.xaml
    /// </summary>
    public partial class PageSalerMenu : Page
    {
        public PageSalerMenu()
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
            FrameSaler.NavigationService.Navigate(new PageAgroomist.PageShowVeget());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ClassMessage.NormalMess("почта для связи Veget@mail.ru \n номер для связи +79999999990");
        }
    }
}
