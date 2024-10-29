using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class product1
    {
        public string Name;
        public double Price;
        public double Discount;

        // Constructor that initializes only the name
        public product1(string name)
        {
            Name = name;
            Price = 0.0;       
            Discount = 0.0;    
            Console.WriteLine($"Constructor 1: Name initialized: {Name}");
        }

        // Constructor that initializes name and price
        public product1(string name, double price) : this(name)
        {
            Price = price;
            Console.WriteLine($"Constructor 2: Price initialized: {Price}");
        }

        // Constructor that initializes name, price, and discount
        public product1(string name, double price, double discount) : this(name, price)
        {
            Discount = discount;
            Console.WriteLine($"Constructor 3: Discount initialized: {Discount}%");
        }

        // Method to calculate the final price after applying discount
        public double CalculateFinalPrice()
        {
            if (Discount > 0)
            {
                return Price - (Price * (Discount / 100));  // Apply discount if available
            }
            return Price;  // Return price as-is if no discount
        }

        // Method to display product details
        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price:C}, Discount: {Discount}%, Final Price: {CalculateFinalPrice():C}");
        }
    }
}
