using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8.	WAP to find the second smallest element in an array.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q8SecondSmallestElement
    {
        public static void SortingArray(int[] arr)
        {
            int minNum = arr[0];
            int secMin = int.MaxValue;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minNum)
                {
                    secMin = minNum;
                    minNum = arr[i];
                }else if (secMin > arr[i] && arr[i] != minNum)
                {
                    secMin = arr[i];
                }
            }
            Console.WriteLine("Secong Smallest Element: "+secMin);
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 12, 35, 30, 9, 3, 45, 32 };

            SortingArray(arr);
        }
    }
}
