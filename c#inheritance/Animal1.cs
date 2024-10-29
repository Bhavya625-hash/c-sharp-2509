using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c__inheritance
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }

    public class Dogs : Animal // Dog is an Animal (is-a relationship)
    {
        public Dogs(string name) : base(name) { }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking");
        }
    }
}
