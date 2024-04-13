using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //15.	check no is palimdrom or not

    internal class Q15PalimdromNum
    {
        static Boolean checkPalindrom(int num)
        {
            int original = num;
            int revNum = 0;

            do
            {
                int rem = num % 10;
                revNum = (revNum * 10) + rem;
                num/= 10;   

            }while (num != 0);

            if (original == revNum) { 
            return true;
            }
            else
            {
                return false;   
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());


            if (checkPalindrom(n))
            {
                Console.WriteLine($"{n} is a palindrome number");
            }
            else
            {
                Console.WriteLine($"{n} is not   palindrome number");
            }
        }
    }
}
