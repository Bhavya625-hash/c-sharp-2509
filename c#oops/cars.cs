using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class cars
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;
        public cars(string make)
        {
            Make = make;
            Console.WriteLine($"Constructor 1: Make: {Make}");
        }
        public cars(string make, string model) : this(make)
        {
            Model = model;
            Console.WriteLine($"Constructor 2: Model i: {Model}");
        }
        public cars(string make, string model, int year) : this(make, model)
        {
            Year = year;
            Console.WriteLine($"Constructor 3: Year : {Year}");
        }
        public cars(string make, string model, int year, double price) : this(make, model, year)
        {
            Price = price;
            Console.WriteLine($"Constructor 4: Price  {Price}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details: Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}");
        }
    }
}
