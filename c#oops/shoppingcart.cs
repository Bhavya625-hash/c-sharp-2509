using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class shoppingcart
    {
        private List<Product> products;

        // Constructor to initialize the product list
        public shoppingcart()
        {
            products = new List<Product>();
        }

        // Method to add a product to the cart
        public void AddProduct(string name, double price, int quantity)
        {
            var product = new Product(name, price, quantity);
            products.Add(product);
            Console.WriteLine($"Added {quantity} x {name} to the cart.");
        }

        // Method to calculate the total price of the products in the cart
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }
            return totalPrice;
        }

        // Nested Product class
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            // Constructor for the Product class
            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
    }
}
