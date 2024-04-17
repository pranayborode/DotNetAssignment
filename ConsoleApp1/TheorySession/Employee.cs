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
        protected int empid;
        protected string empname;
        protected double bs, hra, pf, gross;

        //working with methods
        public Employee()
        {
            empid = 1;
            empname = "Pranay";
            bs = 4600;
            hra = 2000;
            pf = 600;

        }

        //method which accept the values from parameters
        public Employee(int id, string name, double b, double h, double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;
        }

        public virtual void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }

        public virtual string display()
        {
            return $"Employee : empId = {empid}, empName = {empname}, GrossSalary = {gross}";
        }
    }
}
