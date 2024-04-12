using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q1GretestThreeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num3");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine($"{num1} is greatest");
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"{num2} is greatest");
            }
            else
            {
                Console.WriteLine($"{num3} is greatest");
            }
        }
    }
}
