using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.	Write a C# program to count occurrences of a character in given string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q3CountOccurrencesOfCharacter
    {

        public static int CountOccurrenceOfCahr(string str, char ch)
        {
            int count = 0;
           foreach (char c in str)
            {
                if (c == ch)
                {
                    count++;
                }
            }
            return count++;
        }
        static void Main(string[] args)
        {
            string str = "Good Morning";
            Console.WriteLine($"Give String : {str}");


            Console.WriteLine("Enter Char: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

           int count = CountOccurrenceOfCahr(str, ch);

            if(count != 0)
            {
                Console.WriteLine($"Number of occurrences of '{ch}' in the string: {count}");
            }
            else
            {
                Console.WriteLine($"The character '{ch}' is not found in the string.");
            }
        }
    }
}
