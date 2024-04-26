using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//18.	WAP to find longest word in the given sentence
namespace ConsoleApp1.Assignments.String
{
    internal class Q18LongestWordInSentence
    {

        static string LongestWordLength(string str)
        {
            string[] words = str.Split(' ');
            int length = 0;
            string longestWord = "";


            for (int i = 0; i < words.Length; i++)
            {
                if (length < words[i].Length)
                {
                    longestWord = words[i];
                }
            }

            return longestWord;
        }
        static void Main(string[] args)
        {

            string str = "find longest word in the given sentence";

            Console.Write("Longest wotd in given sentence is : "+LongestWordLength(str));

        }
    }
}
