using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab4_16April
{
    internal class CalculateArea
    {


        public static void CalculateAreaRectangle()
        {
            Console.WriteLine("Enter Length of Rectangle");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle");
            double breadth = Convert.ToDouble(Console.ReadLine());

            double area = length * breadth;
            Console.WriteLine($"Area of Rectangle : {area}");
        }

        public static void CalculateAreaTriangle()
        {
            Console.WriteLine("Enter Base of Triangle");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height of Triangle");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * b * h;
            Console.WriteLine($"Area of Triangle : {area}");
        }

        public static void CalculateAreaCircle()
        {
            Console.WriteLine("Enter Radius of Circle");
            double r = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine($"Area of Circle : {area}");
        }

        public static void CalculateAreaSquare()
        {
            Console.WriteLine("Enter Length of Square");
            double length = Convert.ToDouble(Console.ReadLine());

            double area = length * length;
            Console.WriteLine($"Area of Square : {area}");
        }
        static void Main(string[] args)
        {


            Console.WriteLine("1. Calculate Area of Rectangle");
            Console.WriteLine("2. Calculate Area of Triangle");
            Console.WriteLine("3. Calculate Area of Circle");
            Console.WriteLine("4. Calculate Area of Square");

            Console.WriteLine("Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CalculateAreaRectangle();
                    break;
                case 2:
                    CalculateAreaTriangle();
                    break;
                case 3:
                    CalculateAreaCircle();
                    break;
                case 4:
                    CalculateAreaSquare();
                    break;
                default:
                    Console.WriteLine("Invalid Option. Enter valid option");
                    break;
            }

        }
    }
}
