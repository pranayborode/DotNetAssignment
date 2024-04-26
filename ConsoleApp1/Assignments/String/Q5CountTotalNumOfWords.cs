using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5.	Write a C# program to count total number of words in a string. 
namespace ConsoleApp1.Assignments.String
{
    internal class Q5CountTotalNumOfWords
    {
        public static int CountWords(string str)
        {
            int count = 0;
            char[] ch = new char[str.Length];
            for (int i = 0;i<str.Length; i++)
            {
                ch[i] = str[i];
                if (((i > 0) && (ch[i] != ' ') && (ch[i - 1] == ' ')) || ((ch[0] != ' ') && (i == 0)))
                {

                    count++;

                }

            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();

            int countWords = CountWords(str);

            Console.WriteLine("Total Number of Words in Given String : "+countWords);
        }
    }
}
