using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//20.	Accept email_id from user and check valid or not(should contain @,.)
namespace ConsoleApp1.Assignments.String
{
    internal class Q20ValidEmailId
    {
        static void Main(string[] args)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Console.WriteLine("Enter email address:");
            string email = Console.ReadLine();

            bool isValidEmail = Regex.IsMatch(email, pattern);


            if (isValidEmail)
            {
                Console.WriteLine("Valid email address");
            }
            else
            {
                Console.WriteLine("Invalid email address");
            }
        }
    }
}
