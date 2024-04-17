using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.PartialMethods
{
    public partial class Calc2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        partial void Print(int c);
    }
}
