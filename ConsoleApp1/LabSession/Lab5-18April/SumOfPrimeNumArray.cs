using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab5_18April
{
    internal class SumOfPrimeNumArray
    {
        public static bool IsPrimeNum(int num)
        {
            if(num <= 1)
            {
                return false;
            }
            else
            {
                for(int i = 2;i<num; i++)
                {
                    if (num%i == 0)
                    {
                        return false;
                    }
                }
            }
           // Console.WriteLine(num);
            return true;

        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;

            foreach(int num in arr)
            {
                if (IsPrimeNum(num))
                {
                    sum += num;
                }  
               
            }

            Console.WriteLine($"Sum of Prime number is {sum}");

        }
    }
}
