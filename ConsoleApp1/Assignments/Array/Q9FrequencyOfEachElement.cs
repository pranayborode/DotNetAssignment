using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.	WAP to count frequency of each element in an array.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q9FrequencyOfEachElement
    {
        public static void FindFrequency(int[] arr)
        {
            int count;
            bool status;

            for (int i = 0; i < arr.Length; i++)
            {
                count = 1;
                status = false;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        status = true;
                        break;
                    }
                }

                if (status == false)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            count++;
                        }
                    }

                    Console.WriteLine(arr[i] + " -> " + count);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 1, 7, 1, 2, 1, 4, 3, 2 };
            FindFrequency(arr);
        }
    }
}
