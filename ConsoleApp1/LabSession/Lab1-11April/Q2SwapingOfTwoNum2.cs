using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q2SwapingOfTwoNum2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before: a={num1} and b={num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After: a={num1} and b={num2}");
        }
       
    }
}
