using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public abstract class Bird
    {
        // Abstract method
        public abstract void Fly();


        public void LayEggs()
        {
            Console.WriteLine("Bird lays eggs.");
        }
    }

    public interface ISwim
    {
        // Interface method, no implementation
        void Swim();
    }

    public class Duck : Bird, ISwim
    {
        // Implement abstract method Fly from Bird
        public override void Fly()
        {
            Console.WriteLine("Duck fly");
        }

        // Implement method Swim from ISwim
        public void Swim()
        {
            Console.WriteLine("Duck swim");
        }
    }
}
