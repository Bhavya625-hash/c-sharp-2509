using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public abstract class shape
    {
        public virtual void Draw() 
        {
            Console.WriteLine("Drawing a shape");
        }
    }

   // Create the derived class 'Circle'
    public class Circle : shape
    {
        public override void Draw() 
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    //  Create the derived class 'Rectangle'
    public class Rectangle : shape
    {
        public override void Draw() 
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
