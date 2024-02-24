using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Veget.ClassApp
{
    public class ClassMessage
    {
        public static void NormalMess(string Body)
        {
            MessageBox.Show($"{Body}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static void ErrrorMess(string Body)
        {
            MessageBox.Show($"{Body}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static MessageBoxResult ResultMess(string Body)
        {
            return MessageBox.Show($"{Body}", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
