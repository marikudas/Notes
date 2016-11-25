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
using Logic.Model;
using Logic;
namespace Notebook.Authorization
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
                UserMap user = _logic.GetUsers().FirstOrDefault(u => u.Login == loginBox.Text);
                if (user == null)
                    throw new InvalidOperationException("Invalid login!");
                if (user.Password != passwordBox.Password)
                    throw new InvalidOperationException("Wrong password!");
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                exceptionlabel.Content = ex.Message;
            }
        }

        private void SingOutbutton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow RegistrationWindow = new RegistrationWindow();
            RegistrationWindow.Show();
            this.Close();
        }
    }
}
