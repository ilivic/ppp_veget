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

namespace Veget.PageApp.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageAddSal.xaml
    /// </summary>
    public partial class PageAddSal : Page
    {
        public PageAddSal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SAL newSal = new SAL()
                {
                    Title = TxtTitle.Text,
                    caunt = int.Parse(TxtCaunt.Text)
                };
                App.Connection.SAL.Add(newSal);
                App.Connection.SaveChanges();
                ClassMessage.NormalMess("Добавление семян прошло успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
