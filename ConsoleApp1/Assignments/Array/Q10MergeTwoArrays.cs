using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10.	WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q10MergeTwoArrays
    {

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] mergeArray = arr1.Concat(arr2).Distinct().ToArray();

            return mergeArray;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 5, 7, 9, 11 };
            int[] arr2 = { 5, 8, 10, 12, 14 };

            int[] arr3 = MergeArrays(arr1,arr2);

            Console.WriteLine("Merged Array");
            foreach (int item in arr3)
            {
                Console.Write(item+" ");
            }

        }
    }
}
