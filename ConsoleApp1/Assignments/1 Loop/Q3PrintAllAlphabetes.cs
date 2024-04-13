using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments._1_Loop
{
    //3.	Write a program to print all alphabets from a to z. - using  for loop
    internal class Q3PrintAllAlphabetes
    {
        static void printAllAlphabets()
        {
            for(int i =97; i<=122; i++)
            {
                char c = (char)i;
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            printAllAlphabets();
        }
    }
}
