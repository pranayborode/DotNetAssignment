﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.	Write a C# program to trim leading white space characters in a string.
namespace ConsoleApp1.Assignments.String
{
    internal class Q4TrimLeadingWhiteSpace
    {
        static void Main(string[] args)
        {
            string str = "   India     ";
            Console.WriteLine("Original String : "+str);
            Console.WriteLine();

            Console.WriteLine("String After Trim : ");
            Console.WriteLine(str.TrimStart());
        }
    }
}
