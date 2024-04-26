using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12.	Write a C# program to find highest frequency character in a string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q12HighestFrequencyCharacter
    {
        static void FindHIgestFrequencyChar(string str)
        {
            int count;
            int maxCount = 0;
            char maxFreqChar = ' ';
            str=str.ToLower();

            Char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
               if (ch[i] ==' ')
                {
                    continue;
                }

                count = 1; 
                for (int j = i+1; j<ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        count++;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxFreqChar = ch[i];
                    }
                }
            }
            Console.WriteLine($"Higest Freq Char in String is : {maxFreqChar} : {maxCount}");
        }

        static void Main(string[] args)
        {
            string str = "find highest frequency character in a string";

            FindHIgestFrequencyChar(str);
        }
    }

}
