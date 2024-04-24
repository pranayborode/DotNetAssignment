using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13.	Write a  program to test the equality of two arrays.
//Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[] = [52, 22, 62, 12, 42, 22]
//Here both arrays are equal.
namespace ConsoleApp1.Assignments.Array
{
    internal class Q13TestEqualityOfTwoArrays
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

        public static bool CheckEquality(int[]arr1, int[]arr2)
        {
            SortArray(arr1);
            SortArray(arr2);

            if (arr1.Length != arr2.Length)
            {
                return false;
          
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    
                        if (arr1[i] != arr2[i])
                        {
                            return false;
                        }
                    
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 32 };

            if (CheckEquality(arr1, arr2))
            {
                Console.WriteLine("Given arrays are Equal");
            }
            else
            {
                Console.WriteLine("Given arrays are Not Equal");
            }
        }

    }
}
