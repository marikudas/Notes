using System.Collections.Generic;
using System.Windows;
using Logic.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System;
using Presentation.Authorization;
using System.Windows.Documents;
using System.Linq;

namespace Presentation.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Logic.Logic logic = new Logic.Logic();
        private UserMap user;

        public MainWindow(UserMap user)
        {
            InitializeComponent();
            this.user = user;
            RefreshNotebooks();
        }

        private void NewBookButton_Click(object sender, RoutedEventArgs e)
        {
            NewBook newbook = new NewBook(user.Id);
            newbook.Show();
            RefreshNotebooks();
        }

        private void NewNoteButton_Click(object sender, RoutedEventArgs e)
        {
            NewNote newnote = new NewNote((NotebookMap)NotebooksList.SelectedItem);
            newnote.Show();
        }

        private void RefreshNotebooks()
        {
            NotebooksList.ItemsSource = new ObservableCollection<NotebookMap>(logic.GetNotebooks(user.Id));
            comboBox_notebook.ItemsSource = new ObservableCollection<NotebookMap>(logic.GetNotebooks(user.Id));
        }

        private void RefreshNote()
        {
            NoteList.ItemsSource = new ObservableCollection<NoteMap>(logic.GetNotes(((NotebookMap)NotebooksList?.SelectedItem).Id));
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

        private void NotebooksList_Selected(object sender, RoutedEventArgs e)
        {
            RefreshNote();
        }

        private void NoteList_Selected(object sender, RoutedEventArgs e)
        {
            NoteMap note = (NoteMap)NoteList.SelectedItem;
            if (note == null)
            {
                richTextBox.Document.Blocks.Clear();
                TitleTextbox.Text = "";
                DateLabel.Content = "";
                return;
            }
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(note.Text)));       
            DateLabel.Content = note.DateCreated.ToShortDateString();
            TitleTextbox.Text = note.Title;
        }

        private void SearchTextbox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(SearchTextbox.Text == string.Empty)
            {
                RefreshNote();
                return;
            }

            NoteList.ItemsSource = logic.GetNotes(((NotebookMap)NotebooksList.SelectedItem).Id).Where<NoteMap>(n => n.Title.IndexOf(SearchTextbox.Text,StringComparison.OrdinalIgnoreCase)>=0);
            
        }

        private void comboBox_notebook_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (comboBox_notebook.SelectedItem == null)
                return;
            NotebooksList.SelectedItem = comboBox_notebook.SelectedItem;
        }
    }
}
