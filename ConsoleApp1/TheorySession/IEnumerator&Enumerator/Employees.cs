using ConsoleApp1.TheorySession.Collection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.IEnumerator_Enumerator
{
    internal class Employees : IComparable<Employees>
    {
        private int id;
        private string name;
        private double salary;

       

        public Employees(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;   
            this.salary = salary;   
        }

        public int CompareTo(Employees? other) 
        {
          
            if (this.salary > other.salary)
            {
                return 1;
            }
            else if (this.salary < other.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
