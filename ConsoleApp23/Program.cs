using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
            new User("Jale Gurbanova", "jl@gmail.com", "J56789j"),
            new User("Aytac Agharahimova", "aytac@gmail.com", "A1b2c3sdsdsds"),
            };


            foreach (var user in users)
            {
                user.ShowInfo(user.PasswordChecker(user.Password));
            }
        
            
        }
    }
}
