using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.	WAP to put even and odd elements of array in two separate arrays.
namespace ConsoleApp1.Assignments.Array
{
    

    internal class Q4SeparateEvenOddElements
    {
        public static void SeperateEvenOdd(int[] arr)
        {
            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 ==0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++; 
                }
            }

            int[] evenArr = new int[evenCount];
            int[] oddArr = new int[oddCount];

            int evenIndex=0;
            int oddIndex=0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    evenArr[evenIndex++]=num;
                }
                else
                {
                    oddArr[oddIndex++] = num;
                }
            }

            Console.WriteLine("Even Elements : ");
            foreach (int num in evenArr)
            {
                Console.WriteLine(num+" ");
            }

            Console.WriteLine("\nOdd Elements : ");
            foreach (int num in oddArr)
            {
                Console.WriteLine(num + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            SeperateEvenOdd(arr);
        }
        

    }
}
