using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Logic.Model;
using System.Windows.Controls;
using Logic;


namespace Presentation.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для NewBook.xaml
    /// </summary>
    public partial class NewBook : Window
    {
        Logic.Logic logic = new Logic.Logic();
        private int userId;

        public NewBook(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ValidateFields(object sender, RoutedEventArgs e)
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
            try
            {
                logic.AddNotebook(new NotebookMap { Name = NameBox.Text, UserId = userId });
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
