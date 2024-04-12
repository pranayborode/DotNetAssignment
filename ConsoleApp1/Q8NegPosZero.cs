using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q8NegPosZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num");
            int num = Convert.ToInt32(Console.ReadLine());

            string result = (num > 0) ? "Positive" : (num < 0) ? "Negative" : "Zero";

            Console.WriteLine($"{num} is {result}");
        }
    }
}
