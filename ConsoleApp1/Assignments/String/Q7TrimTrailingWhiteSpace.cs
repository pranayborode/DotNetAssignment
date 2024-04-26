using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.	Write a C# program to trim trailing white space characters in a string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q7TrimTrailingWhiteSpace
    {
        static void Main(string[] args)
        {
            string str = "   India     ";
            Console.WriteLine("Original String : " + str);
            Console.WriteLine();

            Console.WriteLine("String After Trim : ");
            Console.WriteLine(str.TrimEnd());
        }
    }
    
}
