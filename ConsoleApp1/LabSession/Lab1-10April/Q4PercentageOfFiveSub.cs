using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q4PercentageOfFiveSub
    {
        static void Main(string[] args)
        {
            int sub1 = 66;
            int sub2 = 87;
            int sub3 = 98;
            int sub4 = 88;
            int sub5 = 76;

            double per = ((sub1 + sub2 + sub3 + sub4 + sub5) / 5);
              
            Console.WriteLine("Percentage of five subject "+per);

        }
    }
}
