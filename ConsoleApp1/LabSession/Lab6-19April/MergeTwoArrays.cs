using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab6_19April
{

    //1.Write a code to merge two array into the  3rd array 
    internal class MergeTwoArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 5, 6, 8, 9 };
            int[] arr2 = { 9,4, 6,2, 0 };

            int mergedLength = arr1.Length+arr2.Length;

            int[] arr3 = new int[mergedLength];

            Array.Copy(arr1,arr3,arr1.Length);

            Array.Copy(arr2,0,arr3,arr1.Length,arr2.Length);


            Console.WriteLine("Merged 3rd Array");
            foreach (int i in arr3)
            {
                Console.Write(i +" ");
            }
        }
    }
}
