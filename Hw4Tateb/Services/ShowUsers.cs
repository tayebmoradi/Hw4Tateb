using Hw4Tateb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb.Services
{
    public class ShowUsers
    {
        UserRepository userRepository = new UserRepository();
        public void ShowAllUsers()
        {
            var Users = userRepository.GetUsers();
            foreach (var item in Users)
            {
                Console.WriteLine($"Id : {item.Id} , FullName : {item.FullName} , DateOfBirth : {item.DateOfBirth} , PhoneNumber : {item.PhoneNumber} , NationalCode : {item.NationalCode}");
            }
        }
    }
}
