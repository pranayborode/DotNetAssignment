using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.DelegateAndEvents
{
    public delegate int MyDelegate(int a, int b);
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }

    }

    public class CalculatorMain
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();

            MyDelegate myDelegate = new MyDelegate(c1.Add);

            // int result = myDelegate.Invoke(30,20);
            // Console.WriteLine("Result: "+result);

            myDelegate += new MyDelegate(c1.Sub);
            myDelegate += new MyDelegate(c1.Mul);

            Delegate[] list = myDelegate.GetInvocationList();

            foreach(Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(30,20));
            }

            Console.WriteLine("------------------------");

            //// to remove method from invocation list
           
            myDelegate -= new MyDelegate(c1.Mul);
            Delegate[] list1 = myDelegate.GetInvocationList();

            foreach (Delegate item in list1)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(30, 20));
            }

        }
    }
}
