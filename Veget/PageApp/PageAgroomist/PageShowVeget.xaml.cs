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

namespace Veget.PageApp.PageAgroomist
{
    /// <summary>
    /// Логика взаимодействия для PageShowVeget.xaml
    /// </summary>
    public partial class PageShowVeget : Page
    {
        public PageShowVeget()
        {
            InitializeComponent();
            ListVeget.ItemsSource = App.Connection.Products.ToList();
        }
    }
}
