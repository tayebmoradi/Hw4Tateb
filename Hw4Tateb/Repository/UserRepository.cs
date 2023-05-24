using Hw4Tateb.DataBase;
using Hw4Tateb.Entity;
using Hw4Tateb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Repository
{
    public class UserRepository : IUser
    {
        
        public bool AddUser(User user)
        {
            var users = GetUsers();
            var serarchuser = from a in users
                              where a.NationalCode == user.NationalCode
                              select a.NationalCode;
            if (serarchuser != null)
            {
                users.Add(user);
                SaveFile.SaveOnCsv(users);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
