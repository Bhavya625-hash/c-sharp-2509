using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public class Animal
    {
        public virtual void MakeSound()// virtual method
        {
            Console.WriteLine("Animal makes  sound.");
        }
    }
    //derived class
    public class Dog : Animal
    {
        // Override MakeSound method for Dog
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        // Override MakeSound method for Cat
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
}
