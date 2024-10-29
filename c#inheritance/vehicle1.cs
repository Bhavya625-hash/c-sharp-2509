using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
  public  abstract class vehicle1
    {
       
        public abstract void Drive();
    }

   
   public class Caar : vehicle1
    {
       
        public override void Drive()
        {
            Console.WriteLine("The car is driving .");
        }
    }

    
    class Bike : vehicle1
    {
       
        public override void Drive()
        {
            Console.WriteLine("The bike is riding");
        }
    }
}
