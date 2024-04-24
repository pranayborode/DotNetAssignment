using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.	WAP to print all negative elements in an array and
//      also count total number of negative elements in an array.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q3PrintCountAllNegativeElements
    {

        public static void PrintAndCountAllNegativeElements(int[] arr)
        {
            int count = 0;
            Console.WriteLine("Negative elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i] +" ");
                    count++;    
                }
            }
            Console.WriteLine("Count: "+count);
        }

        static void Main(string[] args)
        {
            int[] arr = { -1, 5, -8, 6, -9, -2, 0, -4, 7, 8, -3 };

            PrintAndCountAllNegativeElements (arr);
        }
       


    }
}
