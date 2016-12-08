using Database.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
                db.Users.Remove(db.Users
                    .Include(u => u.Notebooks.Select(n => n.Notes))
                    .FirstOrDefault(u => u.Id == user.Id));
                db.SaveChanges();
            }


        }

        public void RemoveNotebook(Notebook notebook)
        {
            using (Entities db = new Entities())
            {
                db.Notebooks.Remove(db.Notebooks
                    .Include(n => n.Notes)
                    .Include(n => n.User)
                    .FirstOrDefault(n => n.Id == notebook.Id));
                db.SaveChanges();
            }


        }

        public void RemoveNote(Note note)
        {
            using (Entities db = new Entities())
            {
                db.Notes.Remove(db.Notes
                    .Include(n => n.Notebooks)
                    .Include(n => n.Notebooks.User)
                    .FirstOrDefault(n => n.Id == note.Id));
                db.SaveChanges();
            }


        }

        public void Update(User user)
        {
            using (Entities db = new Entities())
            {
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
            }

        }

        public void Update(Note note)
        {
            using (Entities db = new Entities())
            {
                db.Notes.AddOrUpdate(note);
                db.SaveChanges();
            }

        }

        public void Update(Notebook notebook)
        {
            using (Entities db = new Entities())
            {
                db.Notebooks.AddOrUpdate(notebook);
                db.SaveChanges();
            }

        }

        public ICollection<User> GetUsers()
        {
            using (Entities db = new Entities())
            {
                return db.Users.Include(u => u.Notebooks.Select(n => n.Notes)).ToList();

            }


        }

        public ICollection<Notebook> GetNotebooks()
        {
            using (Entities db = new Entities())
            {
                return db.Notebooks.Include(n => n.Notes).Include(n => n.User).ToList();
            }


        }

        public ICollection<Note> GetNotes()
        {
            using (Entities db = new Entities())
            {
                return db.Notes.Include(n => n.Notebooks).Include(n => n.Notebooks.User).ToList();

            }


        }

        //By id
        public User GetUser(int userId)
        {
            using (Entities db = new Entities())
            {
                return db.Users.Include(u => u.Notebooks.Select(n => n.Notes)).FirstOrDefault(u => u.Id == userId);

            }
        }

        //By Login
        public User GetUser(string userLogin)
        {
            using (Entities db = new Entities())
            {
                return db.Users.Include(u => u.Notebooks.Select(n => n.Notes)).FirstOrDefault(u => u.Login == userLogin);

            }
        }

        public Notebook GetNotebook(int notebookId)
        {
            using (Entities db = new Entities())
            {
                return db.Notebooks.Include(n => n.User).Include(n => n.Notes).FirstOrDefault(n => n.Id == notebookId);

            }
        }

        public Note GetNote(int noteId)
        {
            using (Entities db = new Entities())
            {
                return db.Notes.Include(n => n.Notebooks)
    .Include(n => n.Notebooks.User)
    .FirstOrDefault(n => n.Id == noteId);
            }

        }
    }
}
