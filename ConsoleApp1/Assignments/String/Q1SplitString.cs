﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
namespace ConsoleApp1.Assignments.String
{
    internal class Q1SplitString
    {
        public static void SplitString(string str)
        {
            string[] st = str.Split("$");  

            foreach (string s in st)
            {
                Console.Write(s+" ");
            }
        }
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";

            SplitString(str);   
        }
    }
}
