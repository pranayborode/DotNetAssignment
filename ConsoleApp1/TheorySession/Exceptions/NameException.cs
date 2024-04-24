using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.Exceptions
{
    public class NameException:Exception
    {
        public NameException(string error) : base(error)
        {
            
        }
    }

    public class Person
    {
         private string name;

        public void AcceptName(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                this.name = name;
                Console.WriteLine("Name : " + name);
            }
            else
            {
                throw new NameException("Name is Empty or Null.. Please provide Name.");
               
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            try
            {
                person.AcceptName(name);
            }catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
