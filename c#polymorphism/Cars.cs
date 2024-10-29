using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public interface IMovable
    {
        void Move();
    }
    public interface IDrawable
    {
        void Draw();
    }
    public class Cars : IMovable, IDrawable
    {
        public void Move()
        {
            Console.WriteLine("Cars moves");
        }
        public void Draw()
        {
            Console.WriteLine("Draw the car");
        }
    }
}
