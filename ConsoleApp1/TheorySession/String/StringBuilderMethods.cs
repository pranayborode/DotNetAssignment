using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.String
{
    internal class StringBuilderMethods
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine("Original String:");
            Console.WriteLine(sb);


            sb.Remove(1, 3);
            Console.WriteLine("After Remove:");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Hello");
            Console.WriteLine("Original String:");
            Console.WriteLine(sb);

            Console.WriteLine("After Replace:");
            sb1.Replace("Hello", "Hi");
            Console.WriteLine(sb1);

            sb.Clear();
            Console.WriteLine("After Clear:"+sb);

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("String Builder in C#");
            Console.WriteLine("Display Capacity and Length");
            Console.WriteLine($"Capacity: {sb2.Capacity}, Length: {sb2.Length}");
        }
    }
}
