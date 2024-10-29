using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    public class shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

   
    class Circle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

   
    class Rectangle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
