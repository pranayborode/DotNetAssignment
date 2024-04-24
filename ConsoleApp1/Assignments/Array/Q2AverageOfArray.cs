using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.	Write two methods that return the average of an array with following headers.
//     i.	public static int average(int[] array)
//     ii. public static double average(double[] array).
//     iii.Write main and invoke the 2 methods.

namespace ConsoleApp1.Assignments.Array
{
    internal class Q2AverageOfArray
    {
        public static int Average(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }

            return sum/arr.Length;
        }

        public static double Average(double[] arr)
        {
            double sum = 0;
            foreach (double item in arr)
            {
                sum += item;
            }

            return sum/arr.Length;
        }

        static void Main(string[] args)
        {
            int[] intArr = { 3, 2, 1, 6, 8, 4 };
            double[] doubleArr = { 10.5, 20.5, 30.5, 40.5, 50.5 };

            Console.WriteLine("int average: " + Average(intArr));
            Console.WriteLine("double average: " + Average(doubleArr));
        }

    }
}
