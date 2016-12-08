using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Logic.Model;
using System.Windows.Documents;

namespace Presentation.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для NewNote.xaml
    /// </summary>
    public partial class NewNote : Window
    {
        Logic.Logic logic = new Logic.Logic();
        private NotebookMap notebook;

        public NewNote(NotebookMap notebook)
        {
            InitializeComponent();
            this.notebook = notebook;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TitleText.Text != null)
                {
                    logic.AddNote(new NoteMap
                    {
                        NotebookId = notebook.Id,
                        DateCreated = DateTime.Now,
                        Title = TitleText.Text,
                        Priority = "Normal",
                        Text = new TextRange(TextNote.Document.ContentStart, TextNote.Document.ContentEnd).Text,

                    });
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
