using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession
{
    abstract public class Shape
    {
        public abstract void CalculateArea();

        public void Display()
        {
            // define some basic info about Shape
        }



    }

    public class Circle : Shape
    {
        private int radius;
        private double result;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            result = 3.14 * radius * radius;
        }
        public string Print()
        {
            return $"Area of circle is {result}";
        }
    }

    public class Rectangle : Shape
    {

        private int length, breadth;
        private double area;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void CalculateArea()
        {
            area = length * breadth;
        }

        public string Print()
        {
            return $"Area of Rectangel is {area}";
        }

    }

}
