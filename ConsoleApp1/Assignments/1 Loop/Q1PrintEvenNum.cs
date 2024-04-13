using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //1.	WAP to print even numbers from 121 to 229 using do-while loop. 
    internal class Q1PrintEvenNum
    {


        static void printEvenNum()
        {
            int i = 121;

            do
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;

            } while (i <= 229);
        }
        static void Main(string[] args)
        {
          printEvenNum();   
        }

    }
}
