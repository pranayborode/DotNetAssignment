using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession
{
    internal class Product
    {
        private int code;
        private string name;    
        private double price;

        public int Code
        {
            set { code = value; }
            get { return code; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Price
        {
            set { price = value; }  
            get { return price; }
        }

       /*
       //Auto implemented property
       //It will create the data member internally and assign the value also tetrieve the value
        public int Code { get; set; }
        public string Name { get; set; }

        public double Price {  get; set; }*/
    }
}
