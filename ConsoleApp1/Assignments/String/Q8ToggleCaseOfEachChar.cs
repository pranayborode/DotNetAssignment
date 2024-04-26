using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8.	Write a C# program to toggle case of each character of a string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q8ToggleCaseOfEachChar
    {

        static string ToggleCase(string str)
        {
            Char[] ch = str.ToCharArray();

            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(ch[i]))
                {
                    ch[i] = Char.ToLower(ch[i]); 
                }else if (Char.IsLower(ch[i]))
                {
                    ch[i] = Char.ToUpper(ch[i]);
                }
            }
            return new string(ch);
        }

        static void Main(string[] args)
        {
            string str = "jAVaProGram";

            Console.WriteLine("Original String: ");
            Console.WriteLine(str);
            Console.WriteLine();

            Console.WriteLine("New String : ");
            Console.WriteLine(ToggleCase(str));
        }
    }
}
