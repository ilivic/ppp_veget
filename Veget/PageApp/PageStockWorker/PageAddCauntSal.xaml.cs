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

namespace Veget.PageApp.PageStockWorker
{
    /// <summary>
    /// Логика взаимодействия для PageAddCauntSal.xaml
    /// </summary>
    public partial class PageAddCauntSal : Page
    {
        public PageAddCauntSal()
        {
            InitializeComponent();
            CMBSal.ItemsSource = App.Connection.SAL.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
               var selectionSla = (CMBSal.SelectedItem as SAL);
                if (selectionSla != null)
                {
                    selectionSla.caunt += int.Parse(TxtCaunt.Text);
                    App.Connection.SaveChanges();
                    ClassMessage.NormalMess("Добвление новых семян прошло успешно");
                }
                else
                {
                    ClassApp.ClassMessage.ErrrorMess("меиена не выбранны");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
