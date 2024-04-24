using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//15.	WAP to arrange the elements of an given array of integers where all negative integers
//      appear before all the positive integers.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q15ArrangeNegativeBeforPositive
    {
        public static void ShiftNegativeAtFront(int[] arr)
        {
            int temp;
            int size = arr.Length;

            for (int i = 0; i<size; i++)
            {
                if (arr[i] < 0)
                {
                    continue;
                }
                else
                {
                    for (int j = size-1; j >= 0 && i<j; j--) 
                    {
                        if (arr[j] < 0)
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            break;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { -1, 2, 3, -4, 0, 5, -4, 8 };
            Console.WriteLine("Original Array :");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            ShiftNegativeAtFront(arr);
            Console.WriteLine("After shifting :");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

    }
}
