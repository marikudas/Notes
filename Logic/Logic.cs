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


    }
}
