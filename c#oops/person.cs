using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class person
    {
        public string Name;
        public int Age;

        public person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public person(person existingperson)
        {
            Name = existingperson.Name;
            Age = existingperson.Age;
        }
        public void display()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}");
        }
    }
}
