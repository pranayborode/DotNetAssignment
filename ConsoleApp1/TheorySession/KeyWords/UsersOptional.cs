using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.KeyWords
{
    internal class UsersOptional
    {
        private string name, city;
        private bool isCustomer;   // user as admin / customer

        public void Accept(string name, string city, bool isCustomer = true, string country = "IND")//bool isCustomer=true -> default argument
        {
            this .name = name;
            this .city = city;
            this.isCustomer = isCustomer;
        }
    }

    public class OptionalMain
    {
        
        static void Main(string[] args)
        {
            UsersOptional user1 = new UsersOptional();

            user1.Accept("Pranay", "Pune");
            UsersOptional user2 = new UsersOptional();
            user2.Accept("Suraj", "Mumbai", false);

            user2.Accept("Rahul", "Pune", true, "US");
        }
    }
}
