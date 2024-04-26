using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16.	Write a C# program to check whether two strings are anagram or not?
namespace ConsoleApp1.Assignments.String
{
    internal class Q16CheckTwoStringAnagram
    {
        public static void SortArray(char[] ch)
        {

            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {

                    if (ch[i] > ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }
        }

        static bool CheckAnagram(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                char[] ch1 = str1.ToCharArray();
                char[] ch2 = str2.ToCharArray();

                SortArray(ch1);
                SortArray(ch2);

                for (int i = 0; i < ch1.Length; i++)
                {

                    if (ch1[i] != ch1[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string str1 = "Race";
            string str2 = "Care";


            if (CheckAnagram(str1, str2))
            {
                Console.WriteLine(str1 + " & " + str2 + " are Anagram");
            }
            else
            {
                Console.WriteLine(str1 + " & " + str2 + " are Not Anagram");
            }
        }
    }
}
