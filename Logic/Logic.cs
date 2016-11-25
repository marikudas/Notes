using System.Collections.Generic;
using System.Linq;
using Database.Model;
using Database;
using Logic.Model;
using Logic.Mapping;


namespace Logic
{
    public class Logic
    {
        private DataAccess _db = new DataAccess();
        private TypeConvertor _convertor = new TypeConvertor();

        public void Register(UserMap user)
        {
            _db.AddUser(_convertor.Convert(user));
        }

        public ICollection<UserMap> GetUsers()
        {
            return _convertor.Convert(_db.GetUsers());
        }
    }
}
