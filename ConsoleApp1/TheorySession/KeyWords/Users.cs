using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.KeyWords
{
    internal class Users
    {
        private string name, city;

        public Users(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
    }

    public class UsersMain
    {
        static void Main(string[] args)
        {

            Users u1 = new Users("Pranay", "Pune");

            Users u2 = new Users(city: "Pune", name: "Pranay");


        }
    }
}
