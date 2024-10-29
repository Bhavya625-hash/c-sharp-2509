using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
   public class vehicle2
    {
        public string Brand;

       
        public vehicle2(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle brand set to: {Brand}");
        }
    }

    // Create the derived class 'Car'
    public class Car : vehicle2
    {
        public string Model { get; set; }

        // Constructor that passes the brand value to the base class constructor
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
            Console.WriteLine($"Car model set to: {Model}");
        }
    }
}

