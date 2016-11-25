using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class NoteMap
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Text { get; set; }
        public DateTime ?Remainder { get; set; }
        public string Priority { get; set; }
        public string Color { get; set; }
        public int NotebookId { get; set; }

        public NotebookMap Notebooks { get; set; }
    }
}
