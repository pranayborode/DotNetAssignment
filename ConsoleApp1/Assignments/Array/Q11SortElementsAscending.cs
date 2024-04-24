using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11.	WAP sort array elements in ascending order.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q11SortElementsAscending
    {

        public static void ShortAscending(int[]arr)
        {
            for (int i = 0;i<arr.Length; i++)
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }

            Console.WriteLine("Sorted Array in Assending Order: ");
            foreach (int num in arr)
            {
                Console.Write(num+" ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 1, 6, 9, 7 };

            Console.WriteLine("Original Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
            ShortAscending(arr);
        }
    }
}
