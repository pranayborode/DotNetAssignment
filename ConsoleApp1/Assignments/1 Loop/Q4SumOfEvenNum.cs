using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{

    //4.	 Write a  program to find sum of all even numbers between 1 to n.
    internal class Q4SumOfEvenNum
    {
        static void findSumOfEvenNum(int n)
        {
            int sum = 0;
            for(int i = 1; i<=n; i++)
            {
                if(i%2==0) {
              
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of all Even Numbers between 1 to {n} is {sum}"); 
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Nth number");
            int n = Convert.ToInt32(Console.ReadLine());

            findSumOfEvenNum(n);
        }
    }
}
