using System.Collections.Generic;
using System.Windows;
using Logic.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System;
using Presentation.Authorization;

namespace Presentation.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Logic.Logic logic = new Logic.Logic();
        private UserMap user;
        private ObservableCollection<NotebookMap> Notebooks;

        public MainWindow(UserMap user)
        {
            InitializeComponent();
            this.user = user;
            RefreshNotebooks();
            NotebooksList.ItemsSource = Notebooks;
        }

        private void NewBookButton_Click(object sender, RoutedEventArgs e)
        {
            NewBook newbook = new NewBook(user.Id);
            newbook.Show();
            RefreshNotebooks();
        }

        private void NewNoteButton_Click(object sender, RoutedEventArgs e)
        {
            NewNote newnote = new NewNote();
            newnote.Show();
        }

        private void RefreshNotebooks()
        {
            Notebooks = new ObservableCollection<NotebookMap>(logic.GetNotebooks(user.Id));
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            StartWindow sw = new StartWindow();
            sw.Show();
            this.Hide();
        }
    }
}
