using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class product
    {
        public string Name { get; set; }
        private float price;
        private int stock;

        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("price cannot be negative");
                }
                price = value;
            }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("price cannot be negative");
                }
                stock = value;
            }
        }
        public product(string name, float productprice, int productstock)
        {
            Name = name;
            Price = productprice;
            Stock = productstock;
        }
    }
    public class order
    {
        private List<product> products = new List<product>();

        public void AddProduct(product product)
        {
            products.Add(product);
        }
        public void orderproduct(string name)
        { 
            var productordered=products.Find(p => p.Name == name);
            
            productordered.Stock--;
            
                      
        }
        public void Displayproductdetails(string name)
        {
            var producttobedisplayed =products.Find(p => p.Name == name);
            Console.WriteLine($"Name:{producttobedisplayed.Name},Price:{producttobedisplayed.Price},Stock:{producttobedisplayed.Stock}");
        }

    }
}
