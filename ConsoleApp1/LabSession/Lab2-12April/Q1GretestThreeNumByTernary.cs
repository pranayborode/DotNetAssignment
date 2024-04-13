using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q1GretestThreeNumByTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num3");
            int num3 = Convert.ToInt32(Console.ReadLine());

           // int greatestByAnd = (num1 > num2) && (num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;

           // Console.WriteLine($"{greatestByAnd} is greatest");
            


            int greatest = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);

            Console.WriteLine($"{greatest} is greatest");
        }
    }
    
}
