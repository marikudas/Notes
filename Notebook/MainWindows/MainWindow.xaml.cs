using System.Collections.Generic;
using System.Windows;
using System.ComponentModel;

namespace Presentation.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public static Logic.Logic logic = new Logic.Logic();

        public MainWindow()
        {
            InitializeComponent();
            Window qwe = new Window();
            
        }

        private void NewBookButton_Click(object sender, RoutedEventArgs e)
        {
            NewBook newbook = new NewBook();
            newbook.Show();
        }

        //private void MainWindow_Closing(object sender, CancelEventArgs e)
        //{
        //    e.Cancel = true;
        //}

        private void NewNoteButton_Click(object sender, RoutedEventArgs e)
        {
            NewNote newnote = new NewNote();
            newnote.Show();
        }
    }
}
