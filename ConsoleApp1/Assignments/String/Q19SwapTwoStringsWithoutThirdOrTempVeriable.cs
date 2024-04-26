using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//19.	How do you swap two string variables without using third or temp variable in C#
namespace ConsoleApp1.Assignments.String
{
    internal class Q19SwapTwoStringsWithoutThirdOrTempVeriable
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";

            Console.WriteLine($"Before Swaping: a = {a}, b = {b}");

            a = a + b;
            b = a.Substring(0, a.Length - b.Length);
            a = a.Substring(b.Length);

            Console.WriteLine($"After Swaping: a = {a}, b = {b}");

        }
    }
}
