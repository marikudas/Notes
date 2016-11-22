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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Notebook.Authorization
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void firstnamebox_LostFocus(object sender, RoutedEventArgs e)
        {

            if (!Regex.IsMatch(firstnamebox.Text, @"(?i)^[a-z]+", RegexOptions.IgnoreCase))
            {
                firstnamebox.BorderBrush = Brushes.Red;
                return;
            }
            firstnamebox.BorderBrush = Brushes.Transparent;
        }
    }
}
