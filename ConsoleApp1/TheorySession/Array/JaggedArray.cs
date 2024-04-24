using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.Array
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];               //Rows are fixed
            arr[0] = new int[] { 9, 4 , 3, 1 };       //0th row has 4 columns
            arr[1] = new int[] { 6, 2, 8};            //1th row has 2 columns
            arr[2] = new int[] { 1, 9, 8, 3, 7, 8};   //2th row has 6 columns
            arr[3] = new int[] { 3, 6, 7, 5, 6};      //3th row has 5 columns

            Console.WriteLine("------Using ForLoop---------");
            for (int i = 0;i< arr.Length; i++)       //arrr.Length returns size of row
            {
                for (int j = 0; j < arr[i].Length; j++) //Col
                {
                    Console.Write($"{arr[i][j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------Using ForEach---------");
            foreach (int[] item in arr)              //assign row to item
            {
                foreach ( int i in item)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
