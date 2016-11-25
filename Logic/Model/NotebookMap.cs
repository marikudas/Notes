using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class NotebookMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BackgroundImagePath { get; set; }
        public int UserId { get; set; }
        
        public  ICollection<NoteMap> Notes { get; set; }
        public  UserMap Users { get; set; }
    }
}
