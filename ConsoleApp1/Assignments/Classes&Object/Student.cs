using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.	Create Student class with roll no, name, accept 3 subjects marks from constructor.
//      Calculate the total marks & percentage. Display student details using ToString()
namespace ConsoleApp1.Assignments.Classes_Object
{
    internal class Student
    {
        private int rollNo;
        private string name;
        private int sub1;
        private int sub2;
        private int sub3;

        public Student(int rollNo, string name, int sub1, int sub2, int sub3)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
                
        }

        public double CalculateTotalMarks()
        {
            return sub1 + sub2 + sub3;
        }

        public double CalculatePercentage()
        {
            double totalMarks = CalculateTotalMarks();
            return (totalMarks / 300) * 100; 
        }

         public override string ToString()
        {
            return $"Student Details:\nRoll No: {rollNo}\nName: {name}\nSub1: {sub1}\nSub2: {sub2}\nSub3: {sub3}\nTotal Marks: {CalculateTotalMarks()}\nPercentage: {CalculatePercentage()}%";
        }

        static void Main(string[] args)
        {
            Student student = new Student(101, "Pranay", 85, 90, 71);
            Console.WriteLine(student.ToString());
        }
    }
}

