using Hw4Tateb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Services
{
    public interface IUser
    {
        List<User> GetUsers();
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool AddUser(User user);
    }
}
