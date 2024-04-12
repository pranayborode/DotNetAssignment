using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q3AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height");
            int h = Convert.ToInt32(Console.ReadLine());

            double area = (0.5) * (b * h);
            Console.WriteLine($"Area of triangle is {area}");
        }

       
    }
}
