using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public class vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving.");
        }
    }

    class Car : vehicle
    {
       
        public override void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }
}
