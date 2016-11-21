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
using Database.Model;

namespace Notebook.Authorization
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        DataClassesDataContext db = new DataClassesDataContext();

        public StartWindow()
        {
            InitializeComponent();
        }

        private void SingInbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Users user = db.Users.FirstOrDefault<Users>(u => u.Login == loginBox.Text);
                if (user == null)
                    throw new InvalidOperationException("Invalid login!");
                if (user.Password != passwordBox.Password)
                    throw new InvalidOperationException("Wrong password!");
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
                this.Close();
            }
            catch(InvalidOperationException ex)
            {
                exceptionlabel.Content = ex.Message;
            }
            catch (Exception ex)
            {
                exceptionlabel.Content = ex.Message;
            }
        }
    }
}
