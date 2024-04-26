using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13.	Write a C# program to find total number of alphabets, digits or special character in a string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q13FindTotalAlphabetsDigitsSpacialChar
    {

        static void CountChar(string str, out int alphaCount, out int digitsCount, out int specialCharCount)
        {
            alphaCount = 0;
            digitsCount = 0;
            specialCharCount = 0;

            foreach (char c in str)
            {
                if (!char.IsWhiteSpace(c)) { 

                    if (char.IsLetter(c))
                    {
                        alphaCount++;
                    }
                    else if (char.IsDigit(c))
                    {
                        digitsCount++;
                    }
                    else
                    {
                        specialCharCount++;
                    }
            }
            }
        }
        static void Main(string[] args)
        {
            string str = "C# program123!!!";

            CountChar(str, out int alphaCount, out int digitsCount, out int specialCharCount);

            Console.WriteLine($"Alphabets   : {alphaCount}");
            Console.WriteLine($"Digits      : {digitsCount}");
            Console.WriteLine($"SpecialChar : {specialCharCount}");
        }
    }
}
