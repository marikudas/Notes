using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Logic
    {
        Database.Model.DataClassesDataContext db = new Database.Model.DataClassesDataContext();

        public Logic()
        {
            
        }

        public User Autorize(string Login, string Pass) {
            return null;
        }

        public User Register(string Login, string Pass, string FistName, string LastName, string EMail)
        {
            return null;
        }

        public List<User> Users {
             get {
                var list = new List<User>();
                foreach (var user in db.Users)
                    list.Add(new User(user));
                return list;
            }
        }

        public void Save() {
            db.SubmitChanges();
        }
    }

    public class User {
        Database.Model.Users user;

        List<Notebook> _notebooks;

        public User(Database.Model.Users user)
        {
            this.user = user;
        }

        public string FirstName { get { return user.FirstName; } set { user.FirstName = value; } }
        public string LastName { get { return user.LastName; } set { user.LastName = value; } }

        public List<Notebook> Notebooks
        {
            get
            {
                if (_notebooks != null) return _notebooks;
                _notebooks = new List<Notebook>();
                foreach (var book in user.Notebooks)
                    _notebooks.Add(new Notebook(book));
                return _notebooks;
            }
        }
    }

    public class Notebook {
        Database.Model.Notebooks notebook;
        public Notebook(Database.Model.Notebooks notebook)
        {
            this.notebook = notebook;
        }

        public string Name => notebook.Name;
        public Database.Model.Notebooks Book => this.notebook;
        public List<Note> Notes { get; set; }
    }

    public class Note : Database.Model.Notes
    {
    }
}
