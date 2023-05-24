using Hw4Tateb.Entity;
using Hw4Tateb.Repository;
using Hw4Tateb.Services;
using Hw4Tateb.Services.ErrorHandeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4Tateb
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShowUsers showUsers = new ShowUsers();
            Random random = new Random();
            UserRepository userRepository = new UserRepository();
            User user = new User();

            bool Flage = true;
            while (Flage)
            {
                Console.WriteLine("Hello dear user");
                Console.WriteLine("Select the desired option");
                Menu.MenuUser();
                Console.WriteLine("Enter the desired number");
                string UserItem = Console.ReadLine();

                if (int.TryParse(UserItem, out int id))
                {
                    if (UserItem == "1")
                    {
                        var Users = userRepository.GetUsers();
                        var UserCount = Users.Count();
                        var Count = Math.Max(0, UserCount + 1);

                        Console.WriteLine("Enter your full name");
                        string Name = Console.ReadLine();

                        Console.WriteLine("Enter your PhoneNumber");
                        string PhoneNumber = Console.ReadLine();

                        Console.WriteLine("Enter your Dateofbirth");
                        Console.WriteLine("sample Code : 5/24/2023 4:07:10 PM");
                        string Dateofbirth = Console.ReadLine();

                        if (PhoneNumber.Length <= 11)
                        {
                            user.Id = Count;
                            user.PhoneNumber = PhoneNumber;
                            user.DateOfBirth = Dateofbirth;
                            user.FullName = Name;
                            user.NationalCode = random.Next(100).ToString();
                            user.CreatedDate = DateTime.Now.ToString();
                            userRepository.AddUser(user);
                            Console.WriteLine("User added successfully");
                            Console.ReadKey();
                        }
                        else
                        {
                            try
                            {
                                throw new PhoneNumberExeption();
                                Console.WriteLine("Press the any key to return to the menu");
                                Console.ReadKey();
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message);
                            }
                        }
                    }
                    else if (UserItem == "2")
                    {
                        showUsers.ShowAllUsers();

                        Console.WriteLine("Please enter the ID of the desired user");
                        Console.WriteLine("Enter your Id");
                        int Id = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Enter your full name");
                        string Name = Console.ReadLine();

                        Console.WriteLine("Enter your PhoneNumber");
                        string PhoneNumber = Console.ReadLine();

                        Console.WriteLine("Enter your Dateofbirth");
                        Console.WriteLine("sample Code : 5/24/2023 4:07:10 PM");
                        string Dateofbirth = Console.ReadLine();
                        Console.WriteLine("Enter your NationalCode");
                        string NationalCode = Console.ReadLine();
                        User user1 = new User() { Id = Id, FullName = Name, NationalCode = NationalCode, PhoneNumber = PhoneNumber, DateOfBirth = Dateofbirth, CreatedDate = DateTime.Now.ToString() };
                        userRepository.UpdateUser(user1);
                    }
                    else if (UserItem == "3")
                    {
                        var Users1 = userRepository.GetUsers();
                        foreach (var item in Users1)
                        {
                            Console.WriteLine($"Id : {item.Id} , FullName : {item.FullName} , DateOfBirth : {item.DateOfBirth} , PhoneNumber : {item.PhoneNumber} , NationalCode : {item.NationalCode}");
                        }
                        Console.WriteLine("Please enter the ID of the desired user");
                        Console.WriteLine("Enter your Id");
                        int DeleteId = Convert.ToInt32(Console.ReadLine());
                        User user2 = new User();
                        foreach (var item in Users1)
                        {
                            if (item.Id == DeleteId)
                            {
                                user2 = item;
                            }

                        }
                        userRepository.DeleteUser(user2);

                    }
                    else if (UserItem == "4")
                    {
                        showUsers.ShowAllUsers();
                    }
                    else
                    {
                        try
                        {
                            throw new MenuExeption();
                            Console.WriteLine("Press the any key to return to the menu");
                            Console.ReadKey();
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                    }
                }
                else
                {
                    try
                    {
                        throw new NumberExeption();
                        Console.WriteLine("Press the any key to return to the menu");
                        Console.ReadKey();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
