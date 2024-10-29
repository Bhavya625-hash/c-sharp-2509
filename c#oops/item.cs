using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class item
    {
        public string Name { get; set; }
        private int stock;
        private float price;

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("invalid value");
                }
                stock = value;
            }
        }
        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("invalid price");
                }
                price = value;
            }
        }
        public item(string name, int itemstock, float itemprice)
        {
            Name = name;
            Stock = itemstock;
            Price = itemprice;
        }
    }
    public class Inventory
    {
        private List<item> items = new List<item>();

        public void Add(item item)
        {
            items.Add(item);
        }
        public void RemoveItem(string name)
        {
            items.RemoveAll(b=> b.Name == name);
        }
        public void UpdateItem(string name,int stock,float price)
        {
           
            var itemtobeupdated =items.Find(b=>b.Name == name);
            if (itemtobeupdated != null)
            {
                itemtobeupdated.Stock = stock;
                itemtobeupdated.Price = price;
            }
        }
        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Name: {item.Name}, Stock: {item.Stock},Price:{item.Price}");
            }
        }
    }
}
