using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF.
//      Accept the value of id, name & basic salary from constructor.
//      Calculate the employee gross salary  & display employee details using ToString() method
//      a.HRA - 40 % of basic salary
//      b.	TA – 20% of basic salary
//      c.	PF -12 % of basic salary

//5.	Use above Employee class, create a static field to auto increment the employee id
//      & create static method to display the total object count.

//6.	Use above Employee class, make a constant fie	ld as PT(professional tax) as 200.
//      Deduct the PT from salary & display the gross salary.
namespace ConsoleApp1.Assignments.Classes_Object
{
    internal class Q1Employee
    {
        private int id;
        private string name;
        private double basicSalary;
        private double hra;
        private double ta;
        private double pf;

        private static int count = 0;
        private const double PT = 200;

        public double CalculateGrossSalary()
        {

            double grossSalary = basicSalary + hra + ta + pf;
            return grossSalary - PT;

        }

        public Q1Employee(int id, string name, double basicSalary)
        {
            this.id = ++count;
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            hra = (basicSalary * 0.4);
            ta = (basicSalary * 0.2);
            pf = (basicSalary * 0.12);
        }

        public override string ToString()
        {
            return $"Employee Details: ID: {id}\nName: {name}\nBasicSalary: {basicSalary}\nHRA: {hra}\nTA: {ta}\nPF: {pf}\nGrossSalary: {CalculateGrossSalary()}"; 
        }
        public static void DisplayTotalCount()
        {
            Console.WriteLine($"Total Objects Count: {count}");
        }

        static void Main(string[] args)
        {
            Q1Employee emp = new Q1Employee(101,"Pranay", 45000.00);

            Console.WriteLine(emp.ToString());

            Q1Employee.DisplayTotalCount();
        }
    }
}
