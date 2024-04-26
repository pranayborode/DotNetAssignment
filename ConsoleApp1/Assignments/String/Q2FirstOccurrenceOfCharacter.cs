using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.	Write a C# program to find first occurrence of a character in a given string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q2FirstOccurrenceOfCharacter
    {

        public static int FindFirstOccurrence(string str, char ch)
        {

           
            for (int i = 0;i<str.Length; i++)
            {
                if (str[i] == ch)
                {
                    return i;
                    break;
                }
            } 
            return -1;
        }
        static void Main(string[] args)
        {
            string str = "Good Morning";

            Console.WriteLine("Enter Char: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int index = FindFirstOccurrence(str, ch); 

            if (index != -1)
            {
                Console.WriteLine($"First Occurence of {ch} is at Index {index}");
            }
            else
            {
                Console.WriteLine($"The character '{ch}' is not found in the string.");
            }

        }
    }
}
