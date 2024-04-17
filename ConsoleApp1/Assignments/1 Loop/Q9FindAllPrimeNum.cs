using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //9.	Find all prime number between 400 to 300;
    internal class Q9FindAllPrimeNum
    {
        public static Boolean CheckPrimeNum(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
    
            for (int i = 400; i >= 300; i--)
            {
                if (CheckPrimeNum(i))
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
