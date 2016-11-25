using System;
using System.Linq;
using System.Windows;
using Logic.Model;
using Logic;
using Presentation.MainWindows;
namespace Presentation.Authorization
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private Logic.Logic _logic = new Logic.Logic();
        public StartWindow()
        {
            InitializeComponent();
        }

        private void SingInbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserMap user = _logic.GetUsers().FirstOrDefault(u => u.Login == LoginBox.Text);
                if (user == null)
                    throw new InvalidOperationException("Invalid login!");
                if (user.Password != PasswordBox.Password)
                    throw new InvalidOperationException("Wrong password!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Exceptionlabel.Content = ex.Message;
            }
        }

        private void SingOutbutton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
    }
}
