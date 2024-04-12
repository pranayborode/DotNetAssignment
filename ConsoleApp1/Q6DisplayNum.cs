using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q6DisplayNum
    {

        static void Main(string[] args)
        {
                for(int i = 1; i<=50; i++)
            {
                if (i % 3 == 0 && i%5==0)
                {
                    Console.WriteLine($"{3}&{5} Welcome to Pune {i}");
                }else if (i%3== 0)
                {
                    Console.WriteLine($"{3} Welcome {i}");
                }else if(i%5== 0)
                {
                    Console.WriteLine($"{5} Pune {i}");
                }
            }
        }
    }
}
