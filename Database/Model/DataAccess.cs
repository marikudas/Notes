using Database.Model;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    public class DataAccess
    {
        public void AddUser(User user)
        {
            using (Entities db = new Entities())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void AddNotebook(Notebook notebook)
        {
            using (Entities db = new Entities())
            {
                db.Notebooks.Add(notebook);
                db.SaveChanges();
            }
        }

        public void AddNote(Note note)
        {
            using (Entities db = new Entities())
            {
                db.Notes.Add(note);
                db.SaveChanges();
            }
        }

        public void RemoveUser(User user)
        {
            using (Entities db = new Entities())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public void RemoveNotebook(Notebook notebook)
        {
            using (Entities db = new Entities())
            {
                db.Notebooks.Remove(notebook);
                db.SaveChanges();
            }
        }

        public void RemoveNote(Note note)
        {
            using (Entities db = new Entities())
            {
                db.Notes.Remove(note);
                db.SaveChanges();
            }
        }

        public void RemoveUser(int userId)
        {
            using (Entities db = new Entities())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                    db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public ICollection<User> GetUsers()
        {
            using (Entities db = new Entities())
            {
                return db.Users.ToList();
            }
        }

        public ICollection<Notebook> GetNotebooks()
        {
            using (Entities db = new Entities())
            {
                return db.Notebooks.ToList();
            }
        }

        public ICollection<Note> GetNotes()
        {
            using (Entities db = new Entities())
            {
                return db.Notes.ToList();
            }
        }
    }
}
