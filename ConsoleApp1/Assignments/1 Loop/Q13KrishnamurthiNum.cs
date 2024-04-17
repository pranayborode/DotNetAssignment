using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{

    //13.	 check no is krishnamurthi or not
    //       153=1!+5!+3!=153

    internal class Q13KrishnamurthiNum
    {

        public static void checkKrishnamurthy(int num)
        {
            int orgNo = num;
            long sum = 0;

            do
            {
                int rem = num % 10;
                sum = sum + calcFactorial(rem);

                num /= 10;
            } while (num != 0);

            if (orgNo == sum)
            {
                Console.WriteLine($"{orgNo}  is a Krishnamurthy number");

            }
            else
            {
                Console.WriteLine($"{orgNo}  is Not a Krishnamurthy number");
            }
        } 

        public static long calcFactorial(int n)
        {
            long fact = 1;
            for(int i=1;i<=n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            checkKrishnamurthy(num);
        }

    }
}
