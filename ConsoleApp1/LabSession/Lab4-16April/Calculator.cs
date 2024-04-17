using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab4_16April
{
    internal class Calculator
    {
        public static double Add(int a , int b)
        {
            return a + b;
        }

        public static double Sub(int a, int b)
        {
            return a - b;
        }

        public static double Mul(int a, int b)
        {
            return a * b;
        }

        public static double Div(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new Exception("Invalid Input...");
            }
           
        }

        public static double Mod(int a, int b)
        {
            if (b != 0)
            {
                return a % b;
            }
            else
            {
                throw new Exception("Invalid Input...");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Addition : "+Add(4,6));

            Console.WriteLine("Subtraction : " + Sub(10, 6));

            Console.WriteLine("Multiplication : " + Mul(4, 6));

            Console.WriteLine("Division : " + Div(9, 3));

            Console.WriteLine("Modulus : " + Mod(5, 3));

        }
    }
}
