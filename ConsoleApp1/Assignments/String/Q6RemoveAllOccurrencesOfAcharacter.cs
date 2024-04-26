using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.	Write a C# program to remove all occurrences of a character from string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q6RemoveAllOccurrencesOfAcharacter
    {

        public static StringBuilder RemoveAllOccurence(string str, char ch)
        {

            str = str.ToLower();
            StringBuilder sb = new StringBuilder(); 

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                {
                    sb.Append(str[i]);
                }
            }

            return sb;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter char to remove : ");
            char ch = Console.ReadKey().KeyChar;

            Console.WriteLine();

            Console.WriteLine("New String : ");
            Console.WriteLine(RemoveAllOccurence(str,ch));

        }
    }
}
