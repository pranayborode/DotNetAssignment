using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //11.	WAP to accept base and index from user and calculates power
    internal class Q11CalculatePower
    {

        static void CalcPower(int _base, int _index)
        {
            double _power = 1;
            for(int i = 1; i<=_index; i++)
            {
                _power *= _base;
            }

            Console.WriteLine($"Base = {_base} Index = {_index} Power = {_power}");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter base :");
            int _base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter index :");
            int _index = Convert.ToInt32(Console.ReadLine());

            CalcPower(_base, _index);

        }
    }
}
