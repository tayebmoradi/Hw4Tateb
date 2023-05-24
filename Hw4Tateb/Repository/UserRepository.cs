using CsvHelper;
using Hw4Tateb.DataBase;
using Hw4Tateb.Entity;
using Hw4Tateb.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
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
            var users = GetUsers();
            var serarchuser = from a in users
                              where a.Id == user.Id
                              select a.Id;
            if (serarchuser != null)
            {
                List<User> tempUsers = new List<User>();
                foreach (User item in users)
                {
                    if (item.Id != user.Id)
                        tempUsers.Add(item);
                }
                SaveFile.SaveOnCsv(tempUsers);
                return true;
            }
            return false;
        }

        public List<User> GetUsers()
        {
            string filePatch = PathFile.PathFileDataBase();
            using (var reader = new StreamReader(filePatch))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<User>();
                if (records != null)
                {
                    return records.ToList();
                }
                else return null;
            }
        }

        public bool UpdateUser(User user)
        {
            var users = GetUsers();
            var search = from a in users
                         where a.Id == user.Id
                         select a.Id;
            if (search != null)
            {
                List<User> Tepmlist = new List<User>();
                foreach (var item in users)
                {
                    if(item.Id != user.Id)
                    { 
                        Tepmlist.Add(item);
                    }
                    else {
                        Tepmlist.Add(user);
                    }
                }
                SaveFile.SaveOnCsv(Tepmlist);   
                return true;
            }
            return false;
        }
    }
}
