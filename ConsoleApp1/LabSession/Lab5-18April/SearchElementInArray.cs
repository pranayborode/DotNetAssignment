using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab5_18April
{
    internal class SearchElementInArray
    {

        static int Search(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return i;   
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Enter num to search :");
            int num = Convert.ToInt32(Console.ReadLine());
          
            if(Search(arr, num) != -1)
            {
                Console.WriteLine($"Element {num} found");
            }
            else
            {
                Console.WriteLine($"Element {num} Not found");
            }
        }
    }
}
