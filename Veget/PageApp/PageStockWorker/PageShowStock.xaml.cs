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

namespace Veget.PageApp.PageStockWorker
{
    /// <summary>
    /// Логика взаимодействия для PageShowStock.xaml
    /// </summary>
    public partial class PageShowStock : Page
    {
        public static List<SAL> _sal {  get; set; }
        public PageShowStock()
        {
            InitializeComponent();

            _sal = new List<SAL>(App.Connection.SAL.ToList());
            ListSal.ItemsSource = _sal;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _sal = _sal.OrderBy(z => z.caunt).ToList();
            ListSal.ItemsSource = _sal;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _sal = _sal.OrderByDescending(z => z.caunt).ToList();
            ListSal.ItemsSource = _sal;

        }
    }
}
