using Database.Model;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    class DataAccess
    {
        public void AddUser(User user)
        {
            using (ModelContainer db = new ModelContainer())
            {
                db.Users.Add(user);
            }
        }

        public void AddNotebook(Notebook notebook)
        {
            using (ModelContainer db = new ModelContainer())
            {
                db.Notebooks.Add(notebook);
            }
        }

        public void AddNote(Note note)
        {
            using (ModelContainer db = new ModelContainer())
            {
                db.Notes.Add(note);
            }
        }

        public void RemoveUser(User user)
        {
            using (ModelContainer db = new ModelContainer())
            {
                db.Users.Remove(user);
            }
        }

        public void RemoveNotebook(Notebook notebook)
        {
            using (ModelContainer db = new ModelContainer())
            {
                db.Notebooks.Remove(notebook);
            }
        }

        public void RemoveNote(Note note)
        {
            using (ModelContainer db = new ModelContainer())
            {
                db.Notes.Remove(note);
            }
        }

        public void RemoveUser(int userId)
        {
            using (ModelContainer db = new ModelContainer())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                    db.Users.Remove(user);
            }
        }

        public List<User> GetUsers()
        {
            using (ModelContainer db = new ModelContainer())
            {
                return db.Users.ToList();
            }
        }
    }
}
