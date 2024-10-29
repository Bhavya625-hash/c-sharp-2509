using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    public class animal
    {
        public void Eat()
        {
            Console.WriteLine(" Animal is eating.");
        }
    }

    
    public class Dog : animal
    {
        
        public void Bark()
        {
            Console.WriteLine(" Dog barks");
        }
    }

    
    public class Puppy : Dog
    {
       
        public void Weep()
        {
            Console.WriteLine(" Puppy weeps");
        }
    }
}
