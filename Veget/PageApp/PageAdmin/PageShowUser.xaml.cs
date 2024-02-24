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

namespace Veget.PageApp.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageShowUser.xaml
    /// </summary>
    public partial class PageShowUser : Page
    {
        public static List<Users> _users { get; set; }
        public static List<Roles> _roles { get; set; }
        public PageShowUser()
        {
            InitializeComponent();
            _users = new List<Users>(App.Connection.Users.ToList());
            ListUserPlits.ItemsSource=_users;
            this.DataContext = this;
            _roles = new List<Roles>(App.Connection.Roles.ToList());
            _roles.Add(new Roles() { Title = "все" });
            CMBRole.ItemsSource = _roles;
        }

        private void ScRole(object sender, SelectionChangedEventArgs e)
        {
            var selectionRole = (sender as ComboBox).SelectedItem as Roles;
            if (selectionRole != null && selectionRole.Title != "все")
            {
                _users = _users.Where(z=>z.Roles == selectionRole).ToList();
            }
            else
            {
                _users = new List<Users>(App.Connection.Users.ToList());
            }
            ListUserPlits.ItemsSource = _users;
            this.DataContext = this;
        }

        private void ClEventUpChar(object sender, RoutedEventArgs e)
        {

            ListUserPlits.ItemsSource = _users.OrderBy(z=>z.Name);
            this.DataContext = this;
        }

        private void ClEventUpId(object sender, RoutedEventArgs e)
        {
            ListUserPlits.ItemsSource = _users.OrderBy(z=>z.UserId);
            this.DataContext = this;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string textSerc = (sender as TextBox).Text;
            if (textSerc != "")
            {
                _users = _users.Where(z => z.Name.Contains(textSerc)).ToList();
            }
            else
            {
                _users = new List<Users>(App.Connection.Users.ToList());
            }
            ListUserPlits.ItemsSource = _users;
            this.DataContext = this;
        }
    }
}
