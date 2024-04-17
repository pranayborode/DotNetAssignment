using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //10.	.WAP to print table of given no
    internal class Q10PrintTable
    {
        static void PrintTable(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num to Print Table");
            int num = Convert.ToInt32(Console.ReadLine());

            PrintTable(num);
        }
    }
}
