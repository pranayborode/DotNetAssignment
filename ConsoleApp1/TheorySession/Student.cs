using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession
{
    internal class Student
    {
        public int rollno;
        public string name;
        public static int count; //default = 0
        public Student()
        {
            count++;
            rollno = count;
            name = "Pranay";
        }

        public Student( string name)
        {
            count++;
            this.rollno = count;
            this.name = name;  
        }

        public static int GetCount()
        {
            return count;
        }

        public string Display()
        {
            return $"RollNo = {rollno}, Name = {name}";
        }
    }
}
