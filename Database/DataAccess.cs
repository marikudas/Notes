﻿using Database.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Database
{
    public class DataAccess
    {
        private readonly Entities _db = new Entities();

        ~DataAccess()
        {
            _db.Dispose();
        }

        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void AddNotebook(Notebook notebook)
        {
            _db.Notebooks.Add(notebook);
            _db.SaveChanges();

        }

        public void AddNote(Note note)
        {

            _db.Notes.Add(note);
            _db.SaveChanges();

        }

        public void RemoveUser(User user)
        {
            _db.Users.Remove(_db.Users
                .Include(u => u.Notebooks.Select(n => n.Notes))
                .FirstOrDefault(u => u.Id == user.Id));
            _db.SaveChanges();

        }

        public void RemoveNotebook(Notebook notebook)
        {

            _db.Notebooks.Remove(_db.Notebooks
                .Include(n => n.Notes)
                .Include(n => n.User)
                .FirstOrDefault(n => n.Id == notebook.Id));
            _db.SaveChanges();

        }

        public void RemoveNote(Note note)
        {
            _db.Notes.Remove(_db.Notes
                .Include(n => n.Notebooks)
                .Include(n => n.Notebooks.User)
                .FirstOrDefault(n => n.Id == note.Id));
            _db.SaveChanges();

        }

        public void RemoveUser(int userId)
        {

            User user = _db.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
                _db.Users.Remove(user);
            _db.SaveChanges();

        }

        public void Update(User user)
        {
            _db.Users.AddOrUpdate(user);
            _db.SaveChanges();
        }

        public void Update(Note note)
        {
            _db.Notes.AddOrUpdate(note);
            _db.SaveChanges();
        }

        public void Update(Notebook notebook)
        {
            _db.Notebooks.AddOrUpdate(notebook);
            _db.SaveChanges();
        }

        public ICollection<User> GetUsers()
        {

            return _db.Users.ToList();

        }

        public ICollection<Notebook> GetNotebooks()
        {

            return _db.Notebooks.ToList();

        }

        public ICollection<Note> GetNotes()
        {

            return _db.Notes.ToList();

        }
    }
}
