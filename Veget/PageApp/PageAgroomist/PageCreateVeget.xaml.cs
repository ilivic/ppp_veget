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
using Veget.ClassApp;

namespace Veget.PageApp.PageAgroomist
{
    /// <summary>
    /// Логика взаимодействия для PageCreateVeget.xaml
    /// </summary>
    public partial class PageCreateVeget : Page
    {
        public PageCreateVeget()
        {
            InitializeComponent();
            CMBSal.ItemsSource = App.Connection.SAL.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selSal = (CMBSal.SelectedItem as SAL);
                int _caunt = int.Parse(TxtCaunt.Text);
                if (_caunt > selSal.caunt)
                {
                    ClassMessage.ErrrorMess("На складе нет столько семян");
                }
                else 
                {
                    var selProduct = App.Connection.Products.Where(z=>z.SalId == selSal.idSal).FirstOrDefault();
                    if (selProduct != null)
                    {
                        selSal.caunt -= _caunt;
                        selProduct.caunt += _caunt;
                        selProduct.DateCrete = DateTime.Now;
                        selProduct.DateDie = DateTime.Now.AddDays(5);
                        App.Connection.SaveChanges();
                        ClassMessage.NormalMess($"выращивание закончено \n продукт будет годен до {selProduct.DateDie.ToString()}");

                    }
                    else
                    {
                        ClassMessage.ErrrorMess("Обратитесь к Администратору для получения типа готовой агрокультуры");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
