using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //2.	 WAP to show the use of break statement ( in for loop)
    internal class Q2UseOfBreakStatement
    {

        static void useBreakStatement()
        {
            for (int i = 1;i<=10; i++)
            {
                if (i == 5)
                {
                  
                    break;
                }
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            useBreakStatement();  
        }
    }
}
