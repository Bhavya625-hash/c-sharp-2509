using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    // early binding
    public class overload
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;

        }
    }
    // late binding
    public class overrideVehicle
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
