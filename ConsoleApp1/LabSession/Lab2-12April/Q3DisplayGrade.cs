using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q3DisplayGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sub1 Marks");
            int sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sub2 Marks");
            int sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sub3 Marks");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sub4 Marks");
            int sub4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sub5 Marks");
            int sub5 = Convert.ToInt32(Console.ReadLine());

            double per = ((sub1 + sub2 + sub3 + sub4 + sub5) / 5);

            Console.WriteLine($"You Score {per}%");

            if (per >= 75)
            {
                Console.WriteLine("Grade A");
            }
            else if (per >= 65)
            {
                Console.WriteLine("Grade B");
            }
            else if (per >= 45)
            {
                Console.WriteLine("Grade C");
            }
            else {
                Console.WriteLine("Fail");
            };
        }
    }
}
