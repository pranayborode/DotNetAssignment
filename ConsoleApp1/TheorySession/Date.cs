using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession
{
    internal class Date
    {
        private int date;
        private string month;
        private int year;

        public Date()
        {
            this.date = 13;
            this.month = "April";
            this.year = 2024;
        }

        public Date(int date, string month, int year)
        {
            this.date = date; 
            this.month = month;
            this.year=year;
        }

        public string Display()
        {
            return $"Date : {date}-{month}-{year}";
        }
    }
}
