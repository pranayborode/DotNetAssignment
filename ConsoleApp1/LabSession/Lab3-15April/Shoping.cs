using ConsoleApp1.TheorySession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LabSession.Lab3_15April
{
    
    internal class Shoping
    {
        private int proId;
        private string proName;
        private double price, total;
        private int qty;


        public void AddProductDetails()
        {
            Console.WriteLine("Enter Product Details");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter Product Id");
            proId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name");
            proName =Console.ReadLine();

            Console.WriteLine("Enter Product Price");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Product Quantity");
            qty = Convert.ToInt32(Console.ReadLine());
        }

        public void CalcBill()
        {
            total = price* qty; 
        }

        private void Display()
        {
            Console.WriteLine("Product Details");
            Console.WriteLine("-----------------------------");

            if (qty > 0)
            {
                Console.WriteLine($"Product Id : {proId}");
                Console.WriteLine($"Product Name : {proName}");
                Console.WriteLine($"Product price : {price}");
                Console.WriteLine($"Product Quantity : {qty}");
                Console.WriteLine($"Total : {total}");
            }
            else
            {
                Console.WriteLine("No Product");
            }
        }

        static void Main(string[] args)
        {
            Shoping s1 = new Shoping();

            s1.AddProductDetails();
            s1.CalcBill();
            s1.Display();

        }
    }
}
