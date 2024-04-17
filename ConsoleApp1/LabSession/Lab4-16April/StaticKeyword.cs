using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab4_16April
{
    internal class StaticKeyword
    {
        public static int count = 0;

        public StaticKeyword()
        {
            count++;
        }

        public static void GetCount()
        {
            Console.WriteLine("Count: "+count);
        }
        static void Main(string[] args)
        {

            StaticKeyword sk1 = new StaticKeyword();
            StaticKeyword sk2 = new StaticKeyword();
            StaticKeyword sk3 = new StaticKeyword();

            GetCount();



        }
    }
}
