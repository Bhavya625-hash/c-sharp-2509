using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public abstract class Vehicle
    { 
       
        
            // Abstract method 
            public abstract void StartEngine();

           
            public void StopEngine()
            {
                Console.WriteLine("Engine stopped.");
            }
    }

        // Derived Car class
        public class Car : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Car engine started");
            }
        }

        // Derived Motorcycle class
        public class Motorcycle : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Motorcycle engine started ");
            }
        }
}

