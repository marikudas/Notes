using System.Collections.Generic;

namespace Logic.Model
{
    public class NotebookMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BackgroundImagePath { get; set; }
        public int UserId { get; set; }

        public ICollection<NoteMap> Notes { get; set; }
        public UserMap User { get; set; }
    }
}
