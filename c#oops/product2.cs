using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class product2
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        // Constructor to initialize all properties
        public product2(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // Constructor with default values
        public product2()
        {
            Name = "Unknown Product";
            Price = 0.0;
            Category = "Misc";
        }

        // Static factory method to create a Product
        public static product2 CreateProduct(string name, double price, string category)
        {
            return new product2(name, price, category);
        }

        // Method to display product details
        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price:C}, Category: {Category}");
        }
    }
}
