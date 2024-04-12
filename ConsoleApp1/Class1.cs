using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;

            Console.WriteLine($"Addition of {a} and {b} is {c}");
        }
    }
}
