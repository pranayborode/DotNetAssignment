using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.	WAP to find and count total number of duplicate elements in an array.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q6CountDuplicateElements
    {
        public static void SortArray(int[] arr)
        {

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] > arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }


        public static int CountDuplicate(int[] arr)
        {

           SortArray(arr);

            int duplicateCount = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    duplicateCount++;
                }
            }
            return duplicateCount;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 2, 3, 4, 4, 5, 6, 7, 7 };

            int duplicateCount = CountDuplicate(arr);

            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);

        }


    }
}
