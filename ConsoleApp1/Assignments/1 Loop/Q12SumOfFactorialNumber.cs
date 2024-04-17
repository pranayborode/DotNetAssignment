using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //12.	s=1!+2!+3!.........+n! find s
    internal class Q12SumOfFactorialNumber
    {

        static int Factorial(int num)
        {
            int result = 1;
            if (num == 0)
            {
                return 1;
            }
            else
            {
               for(int i = 2; i <= num; i++) { 

                    result *= i;
                }
               return result;
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Num :");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for(int i = 1; i <= num; i++)
            {
                sum += Factorial(i);
            }

            Console.WriteLine($"The sum of Factorials from 1 to {num}  is : {sum}");
        }


    }
}
