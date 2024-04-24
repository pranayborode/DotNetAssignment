using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.String
{
    internal class MethodImplement
    {
        public static bool CheckIsEmptyOrNull(string str)
        {
           return string.IsNullOrWhiteSpace(str);
        }

        public static string Concat(string str2, string str3)
        {
            return string.Concat(str2, str3);
        }

        public static char CharAt(string str, int index)
        {
            return str[index];
        }

        public static char[] ToCharArray(string str)
        {
            return str.ToCharArray();
        }

        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string ToLower(string str) 
        {
            return str.ToLower();
        }

        public static int IndexOf(string str, string word)
        {
            return str.IndexOf(word); 
        }

        public static int LastIndexOf(string str, string word)
        {
            return str.LastIndexOf(word);
        }

        public static string Substring(string str, int startIndex, int length)
        {
            return str.Substring(startIndex, length);   
        }

        public static bool Contains(string str, string word)
        {
            return str.Contains(word);  
        }

        public static string[] Split(string str, char spt)
        {
            return str.Split(spt);
        }

        public static string Trim(string str)
        {
            return str.Trim();
        }
        static void Main(string[] args)
        {
            string str1 = "";

            string str2 = "Hello";

            string str3 = " World";

            string str4 = "I Love India";

            string str5 = "  I Love Programing   ";

            if (string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("string is empty or null");
            }
            else
            {
                Console.WriteLine("string is Not empty or null"+str2);
            }

            Console.WriteLine($"Concat: {Concat(str2,str3)}");

            Console.WriteLine($"CharAt: {CharAt(str2,1)}");

            Console.WriteLine($"ToCharArray: {string.Join(", ", ToCharArray(str2))}");

            Console.WriteLine($"ToUpper: {str2.ToUpper()}");

            Console.WriteLine($"ToUpper: {str2.ToLower()}");

            Console.WriteLine($"IndexOf: {IndexOf(str4, "Love")}");

            Console.WriteLine($"LastIndexOf: {LastIndexOf(str4, "Love")}");

            Console.WriteLine($"Substring: {Substring(str4, 3, 2)}");

            Console.WriteLine($"Contains: {Contains(str4, "India")}"); // return true

            Console.WriteLine($"Split: {string.Join(",",Split( str4, ' ' ))}");

            Console.WriteLine(Trim(" " + str5 + " "));
        }
    }
}
