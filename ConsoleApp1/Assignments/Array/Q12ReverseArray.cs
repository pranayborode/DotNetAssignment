using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12.	WAP to reverse the array itself, don’t print array in reverse –
//I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
//so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q12ReverseArray
    {

        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }


        public static void ReversedArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;


                start++;
                end--;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            ReversedArray(arr);
            Console.WriteLine();
            Console.WriteLine("Reversed Array:");
            PrintArray(arr);

        }
    }
}
