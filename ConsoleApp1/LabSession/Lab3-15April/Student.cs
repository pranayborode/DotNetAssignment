using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab3_15April
{
    internal class Student
    {
        private int stdId;
        private string stdName;
        private int sub1, sub2, sub3;
        private double per;

        public void AddStudentDetails()
        {
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter Your Id");
             stdId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Name");
            stdName = Console.ReadLine();

            Console.WriteLine("Enter Sub1 Marks");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sub2 Marks");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sub3 Marks");
            sub3 = Convert.ToInt32(Console.ReadLine());

        }

        public void CalcPercentage()
        {
             per = (sub1 + sub2 + sub3) / 5;
        }

        public void DisplayStdDetails()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Student Id : {stdId}");
            Console.WriteLine($"Student Name : {stdName}");
            Console.WriteLine("Subject Marks");
            Console.WriteLine($"Sub1 : {sub1}, Sub2 : {sub2}, Sub3 : {sub3}");
            Console.WriteLine($"Percentage : {per}%");
        }
        static void Main(string[] args)
        {
                Student s1 = new Student();

            s1.AddStudentDetails();
            s1.CalcPercentage();
            s1.DisplayStdDetails();
           
            
        }
    }
}
