using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IfElseDemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You are undrage");
            }
        }
    }
}
