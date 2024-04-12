using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q1AreaOfCircle
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Radius");
            int r = Convert.ToInt32(Console.ReadLine());

            double area = Math.PI * (r * r);

            Console.WriteLine("Area of circle is " + area);
        }
    }
}
