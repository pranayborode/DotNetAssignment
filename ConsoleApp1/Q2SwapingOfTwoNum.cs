using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q2SwapingOfTwoNum
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before: a={a} and b={b}");

            a = a+ b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After: a={a} and b={b}");
        }
    }
}
