using Database.Model;
using System.Collections.Generic;
using System.Windows;

namespace Notebook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataClassesDataContext Database { get; set; } = new DataClassesDataContext();

        public static Logic.Logic logic = new Logic.Logic();

        public MainWindow()
        {
            InitializeComponent();
            Window qwe = new Window();
            
        }

        public List<Logic.User> Users { get; set; } = logic.Users;
    }
}
