using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Text.RegularExpressions;
using Logic.Model;
using Logic;

namespace Presentation.Authorization
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private Logic.Logic _logic = new Logic.Logic();

        public RegistrationWindow()
        {
            InitializeComponent();
            
        }

        private void ValidateFields()
        {
            foreach(TextBox textBox in SPanel.Children.OfType<TextBox>())
            {
                if (textBox.BorderBrush == Brushes.Red || textBox.Text == string.Empty)
                {
                    SignUpbutton.IsEnabled = false;
                    return;
                }
                SignUpbutton.IsEnabled = true;
            }
        }

        private void ValidateBoxOnLostFocus(object sender, RoutedEventArgs e)
        {

            if (!Regex.IsMatch(((TextBox)sender).Text, @"^[a-z]+$", RegexOptions.IgnoreCase))
            {
                ((TextBox)sender).BorderBrush = Brushes.Red;
                ValidateFields();
                return;
            }
            ((TextBox)sender).BorderBrush = Brushes.Transparent;
            ValidateFields();
        }

        private void LogAndPassOnLostFocus(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(((TextBox)sender).Text, @"^\w+$", RegexOptions.IgnoreCase))
            {
                ((TextBox)sender).BorderBrush = Brushes.Red;
                ValidateFields();
                return;
            }
            ((TextBox)sender).BorderBrush = Brushes.Transparent;
            ValidateFields();
        }

        private void emailbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(((TextBox)sender).Text, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$", RegexOptions.IgnoreCase))
            {
                ((TextBox)sender).BorderBrush = Brushes.Red;
                ValidateFields();
                return;
            }
            ((TextBox)sender).BorderBrush = Brushes.Transparent;
            ValidateFields();
        }

        private void SignUpbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserMap user = new UserMap
                {
                    FirstName = Firstnamebox.Text,
                    LastName = Lastnamebox.Text,
                    Login = Loginbox.Text,
                    Password = Passbox.Text,
                    Email = Emailbox.Text
                };
                _logic.Register(user);
                
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                this.Close();
            }
        }
    }
}
