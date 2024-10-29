using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public abstract class shapes
    {
        public abstract double CalculateAreass();
    }
    public interface IShapes
    {
        void DisplayShape();
    }
    public class Circles : shapes, IShapes
    {
        public double Radius;
        public Circles(double radius)
        {
            Radius = radius;
        }
        public override double CalculateAreass()
        {
            return 3.14 * Radius * Radius;
        }
        public void DisplayShape()
        {
            Console.WriteLine("shape type: Circle");
        }
    }
}
