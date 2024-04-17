using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.Array
{
    internal class _2DMatrixAddition
    {


        public static void AcceptData(int[,]arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.WriteLine($"Enter value for [{i},{j}]");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void Main(string[] args)
        {

            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] result = new int[3, 3];

            Console.WriteLine("Enter Matrix1");
            AcceptData(arr1);
            Console.WriteLine("Enter Matrix2");
            AcceptData(arr2);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            Console.WriteLine("Dispay Addition");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
