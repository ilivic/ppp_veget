using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
    /// Логика взаимодействия для PageAuitho.xaml
    /// </summary>
    public partial class PageAuitho : Page
    {
        public PageAuitho()
        {
            InitializeComponent();
        }

        private void ClEventRegistration(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageReg());
        }

        private void ClEventAuthorization(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtLogin.Text != "" && TxtPassword.Password != "")
                {
                    if (TxtLogin.Text == "@")
                    {
                        if (TxtPassword.Password == "Admin")
                        {
                            ClassMessage.NormalMess("Доброе Утро Администратор");
                            NavigationService.Navigate(new PageAdmin.PageMenuAdmin());
                        }
                        else
                        {
                            ClassMessage.ErrrorMess("Неверный пароль для Администратора");
                        }
                    }
                    else if (TxtLogin.Text == "$")
                    {
                        if (TxtPassword.Password == "Agro")
                        {
                            ClassMessage.NormalMess("Добрый день Агроном");
                            NavigationService.Navigate(new PageAgroomist.PageMenuAgro());
                        }
                        else
                        {
                            ClassMessage.ErrrorMess("Неверный пароль для сладского рабочего");
                        }
                    }
                    else if (TxtLogin.Text == "%")
                    {
                        if (TxtPassword.Password == "Stock")
                        {
                            ClassMessage.NormalMess("Добрый вечер сладской рабочии");
                            NavigationService.Navigate(new PageStockWorker.PageMenuStock());
                        }
                        else
                        {
                            ClassMessage.ErrrorMess("Неверный пароль для Агронома");
                        }
                    }
                    else
                    {

                        var UserData = App.Connection.Users.Where(z => z.Password == TxtPassword.Password && z.Login == TxtLogin.Text).FirstOrDefault();
                        if (UserData != null)
                        {
                            if (UserData.RoleId == 4)
                            {
                                ClassMessage.NormalMess($"Добрый день уважаемый \n {UserData.Name}");
                                ClassCorrUser.CorrUser = UserData;
                                NavigationService.Navigate(new PageSalerMenu());
                            }
                            else if (UserData.RoleId == 3)
                            {
                                ClassMessage.NormalMess($"Добрый день уважаемый \n {UserData.Roles.Title}");
                                ClassCorrUser.CorrUser = UserData;
                                NavigationService.Navigate(new PageStockWorker.PageMenuStock());
                            }
                            else if (UserData.RoleId == 2)
                            {
                                ClassMessage.NormalMess($"Добрый день уважаемый \n {UserData.Roles.Title}");
                                ClassCorrUser.CorrUser = UserData;
                                NavigationService.Navigate(new PageAgroomist.PageMenuAgro());
                            }
                            else if (UserData.RoleId == 1)
                            {
                                ClassMessage.NormalMess($"Добрый день уважаемый \n {UserData.Roles.Title}");
                                ClassCorrUser.CorrUser = UserData;
                                NavigationService.Navigate(new PageAdmin.PageMenuAdmin());
                            }
                        }
                        else
                        {
                            ClassMessage.ErrrorMess("Данного пользователя не существует");
                        }
                    }
                }
                else 
                {
                    ClassMessage.ErrrorMess("Не все поля заполнены");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
