using Database.Model;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    class DataAccess
    {
        public void AddUser(User user)
        {
            using (Entities db = new Entities())
            {
                db.Users.Add(user);
            }
        }

        public void AddNotebook(Notebook notebook)
        {
            using (Entities db = new Entities())
            {
                db.Notebooks.Add(notebook);
            }
        }

        public void AddNote(Note note)
        {
            using (Entities db = new Entities())
            {
                db.Notes.Add(note);
            }
        }

        public void RemoveUser(User user)
        {
            using (Entities db = new Entities())
            {
                db.Users.Remove(user);
            }
        }

        public void RemoveNotebook(Notebook notebook)
        {
            using (Entities db = new Entities())
            {
                db.Notebooks.Remove(notebook);
            }
        }

        public void RemoveNote(Note note)
        {
            using (Entities db = new Entities())
            {
                db.Notes.Remove(note);
            }
        }

        public void RemoveUser(int userId)
        {
            using (Entities db = new Entities())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                    db.Users.Remove(user);
            }
        }

        public List<User> GetUsers()
        {
            using (Entities db = new Entities())
            {
                return db.Users.ToList();
            }
        }
    }
}
