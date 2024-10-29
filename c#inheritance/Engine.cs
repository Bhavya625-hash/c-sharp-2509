using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    public class Engine
    {
        public int HorsePower;

        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }

        public void EngineDetails()
        {
            Console.WriteLine($"Engine Horsepower: {HorsePower} HP");
        }
    }

    // Step 2: Define the Car class with an Engine instance (has-a relationship)
    public class Cars
    {
        public string Model;
        public Engine Engine;  // Car "has-a" Engine

        public Cars(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public void ShowCarDetails()
        {
            Console.WriteLine($"Car Model: {Model}");
            Engine.EngineDetails();  
        }
    }
}
