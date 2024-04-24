using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab5_18April
{
    abstract class AbstractClass
    {
        public int num1;

        protected AbstractClass(int value)
        {
            num1 = value;
        }

        public abstract void Display();
    }

    interface IInterface {

        int num2 { get; set; }

    }

    class ChildClass : AbstractClass, IInterface
    {

        public int num2 { get; set; }

        public ChildClass(int value) : base(value)
        {
            num2 = 3;
        }

      


        public override void Display()
        {
            Console.WriteLine("Sum of variables: " + (num1 + num2));
        }
    }
}
