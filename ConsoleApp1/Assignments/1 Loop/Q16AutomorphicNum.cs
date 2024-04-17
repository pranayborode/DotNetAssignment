using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //16.	check no is automorphic or not
    //      input n = 25
    //      output Automorphic as 25*25=625

    internal class Q16AutomorphicNum
    {
        public static Boolean CheckAutomorphic(int num)
        {
            long square = (long)num * num;

            while (num > 0)
            {
                if (num % 10 != square % 10) 
                {
                    return false;
                }
                num /= 10;
                square /= 10;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (CheckAutomorphic(num))
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }
        }
    }
}
