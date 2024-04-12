using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Practice
{
    internal class BiggestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
        }
    }
}
