using Logic.Model;
using Presentation.MainWindows;
using System;
using System.Windows;
namespace Presentation.Authorization
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private readonly Logic.Logic _logic = new Logic.Logic();
        public StartWindow()
        {
            InitializeComponent();
        }

        private void SingInbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserMap user = _logic.GetUser(LoginBox.Text);
                if (user == null)
                    throw new InvalidOperationException("Invalid login!");
                if (user.Password != PasswordBox.Password)
                    throw new InvalidOperationException("Wrong password!");
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.Show();
                Close();
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
            Close();
        }
    }
}
