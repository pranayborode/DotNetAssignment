using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//1.	WAP to search for a given number in an array and accordingly print the index if exists
namespace ConsoleApp1.Assignments.Array
{
    internal class Q1SearchNumInArray
    {
        public static void SearchNum(int[]arr, int num)
        {
            int foundIndex = -1;
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    foundIndex = i;
                    break;
                }
              
            }

            if (foundIndex != -1)
            {
                Console.WriteLine($"Given Number {num} is Present in Array at Index: {foundIndex}");
            }
            else
            {
                Console.WriteLine($"Given Number {num} is not Present in Array");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 1, 2, 7, 8, 0 };
            Console.WriteLine("Enter Num to Search in Array:");
            int num = Convert.ToInt32(Console.ReadLine());

            SearchNum(arr,num);

        }
    }
}
