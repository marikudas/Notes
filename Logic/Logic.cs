using Database;
using Logic.Mapping;
using Logic.Model;
using System.Collections.Generic;
using System.Linq;


namespace Logic
{
    public class Logic
    {
        private readonly DataAccess _db = new DataAccess();
        private readonly TypeConvertor _convertor = new TypeConvertor();

        public void Register(UserMap user)
        {
            _db.AddUser(_convertor.Convert(user));
        }

        public ICollection<UserMap> GetUsers()
        {
            return _convertor.Convert(_db.GetUsers());
        }

        public UserMap GetUser(int userId)
        {
            return _convertor.Convert(_db.GetUser(userId));
        }

        public UserMap GetUser(string userLogin)
        {
            return _convertor.Convert(_db.GetUser(userLogin));
        }

        public ICollection<NotebookMap> GetNotebooks(int userId)
        {
            return _convertor.Convert(_db.GetNotebooks()).Where<NotebookMap>(n => n.UserId == userId).ToList();
        }

        public void AddNotebook(NotebookMap notebook)
        {
            _db.AddNotebook(_convertor.Convert(notebook));
        }
    }
}
