using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession
{
    internal class Employee
    {
        //declare the data members
        private int empid;
        private string empname;
        private double bs, hra, pf, gross;

        //working with methods
        public void Assign()
        {
            empid = 1;
            empname = "Pranay";
            bs = 4600;
            hra = 2000;
            pf = 600;

        }

        //method which accept the values from parameters
        public void Accept(int id, string name, double b, double h, double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;
        }

        public void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }

        public string display()
        {
            return $"empId = {empid}, empName = {empname}, GrossSalary = {gross}";
        }
    }
}
