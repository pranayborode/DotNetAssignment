using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.Array
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

       /* public Product(int Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price; 
        }*/

        public void DisplayDetails()
        {
            Console.WriteLine("Product Details");
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine("------------------------");
        }
    }


    class MainClass
    {
        static void Main(string[] args)
        {
            Product[] pro = new Product[5];

            pro[0] = new Product { Id = 1, Name = "Laptop",Price =  45000 };

            pro[1] = new Product {Id=  2, Name = "Mobile", Price = 35000 };

            pro[2] = new Product{ Id = 3, Name = "Headphone", Price = 4500 };

            pro[3] = new Product{ Id = 4, Name = "SmartTV", Price = 55000 };

            pro[4] = new Product{ Id = 5, Name = "SmartWatch", Price = 5500 };

            foreach (Product p in pro)
            {
               p.DisplayDetails();
            }
        }
    }
}
