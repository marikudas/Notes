using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Presentation.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для NewBook.xaml
    /// </summary>
    public partial class NewBook : Window
    {
        public NewBook()
        {
            InitializeComponent();
        }

        private void ValidateFields()
        {
                if (NameBox.Text == string.Empty)
                {
                    ok.IsEnabled = false;
                    return;
                }
                ok.IsEnabled = true;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
