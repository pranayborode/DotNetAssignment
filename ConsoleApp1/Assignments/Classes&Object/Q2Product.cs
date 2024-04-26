using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.	Create class Product. Add fields like id, name and price.
// Create properties for each field. Use object initializer syntax
// initialize the object. Print product details using ToString()

//3.Use above Product class, create Discount method & accept the discount percentage.
//Give discount to the price & Display actual price & discounted price
namespace ConsoleApp1.Assignments.Classes_Object
{
    internal class Q2Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public override string ToString()
        {
            return $"ProductId: {ProductID}, ProductName: {ProductName}, ProductPrice: {ProductPrice}";
        }

        public void ApplyDiscount(double discPer)
        {
            double discAmount = ProductPrice * (discPer / 100);
            double discPrice = ProductPrice - discAmount;

            Console.WriteLine($"Actual Price  : {ProductPrice}");
            Console.WriteLine($"Discount Price: {discPer}% off : {discPrice}");
        }

        static void Main(string[] args)
        {
            Q2Product product = new Q2Product 
            {
                ProductID=101, 
                ProductName="Laptop", 
                ProductPrice=45000
            };

            Console.WriteLine(product.ToString());

            Console.WriteLine("***************************************");

            Console.WriteLine("Enter Discount Percentage: ");
            double discPer = Convert.ToDouble(Console.ReadLine());

            product.ApplyDiscount(discPer);
        }
    }

}
