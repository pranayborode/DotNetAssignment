using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession
{
    internal class Manager:Employee
    {
        private double food;

        public Manager() : base()
        {

        }

        public Manager(int id, string name, double b, double h, double p, double food) 
            : base(id, name, b, h, p)
        {
            this.food = food;
        }


        public override void CalculateSalary()
        {
            gross = (bs + hra +food) - pf;
        }

        public override string display()
        {
            return $"Manager: empId = {empid}, empName = {empname}, GrossSalary = {gross}, food = {food}";
        }
    }
}
