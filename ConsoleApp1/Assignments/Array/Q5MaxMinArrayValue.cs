using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5.	WAP to find the maximum and minimum value in an array.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q5MaxMinArrayValue
    {

        public static void FindMaxMin(int[]arr)
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max Value in Array is : "+max);
            Console.WriteLine("Min Value in Array is : " +min);
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 6, 8, 4 };

            FindMaxMin(arr);    
        }
    }
}
