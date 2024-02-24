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
using System.IO;
using Microsoft.Win32;
using System.Net.Http.Headers;
using Veget.ADOApp;
using Veget.ClassApp;

namespace Veget.PageApp.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageAddVeget.xaml
    /// </summary>
    
    public partial class PageAddVeget : Page
    {
        public static byte[] _image {  get; set; }
        public PageAddVeget()
        {
            InitializeComponent();
            CMBCat.ItemsSource = App.Connection.Cat.ToList();
            CmbSal.ItemsSource = App.Connection.SAL.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                _image = File.ReadAllBytes(dialog.FileName);
                (sender as Button).Background = Brushes.Green;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try 
            {
                Products newProd = new Products()
                {
                    Title = TxtName.Text,
                    Price = int.Parse(TxtPrice.Text),
                    Image = _image,
                    caunt = 0,
                    Cat = (CMBCat.SelectedItem as Cat),
                    SAL = (CmbSal.SelectedItem as SAL)
                };
                App.Connection.Products.Add(newProd);
                App.Connection.SaveChanges();
                ClassMessage.NormalMess("Добавление прошло успешно");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
