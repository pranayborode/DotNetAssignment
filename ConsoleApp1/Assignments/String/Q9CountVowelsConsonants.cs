using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//9.	Write a C# program to count total number of vowels and consonants in a string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q9CountVowelsConsonants
    {
        static void CountVowelsConsonants(string str, out int vCount,out int cCount)
        {
             vCount = 0;
             cCount = 0;

            str =str.ToLower();
            char[] chars = str.ToCharArray();

            for (int i = 0; i<str.Length; i++)
            {
                if (chars[i] =='a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u')
                {
                    vCount++;
                }else if (chars[i]>'a' && chars[i] < 'z')
                {
                    cCount++;
                }
               
            }
        }
        static void Main(string[] args)
        {
            string str = "total number of vowels and consonants in a string";
            Console.WriteLine("Original String : ");
            Console.WriteLine(str);
            Console.WriteLine();

            int vCount, cCount;
            CountVowelsConsonants(str, out vCount, out cCount);

            Console.WriteLine($"Total number of vowels: {vCount}");
            Console.WriteLine($"Total number of consonants: {cCount}");
        }
    }
}
