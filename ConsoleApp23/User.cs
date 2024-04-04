using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class User : IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }



      public bool PasswordChecker(string password)
        {
            bool hasLower = false;
            bool hasUpper = false;
            bool hasDigit = false;


            if (password.Length < 8)
            {
                Console.WriteLine("En az 8 simvoldan ibaret olmalidir");
            }
            else
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        hasUpper = true;
                    }

                    if (char.IsLower(c))
                    {
                        hasLower = true;
                    }
                    if (char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                }

            }

            bool check = hasDigit && hasLower && hasUpper;
            return check;

        }

        public void ShowInfo(bool check) 
        {

            Console.WriteLine($"FullName:{FullName}");
            Console.WriteLine($"Email:{Email}");
            Console.WriteLine($"Password:{check}");
        }
    }
}
