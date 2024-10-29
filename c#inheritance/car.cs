using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    interface IDriveable
    {
        void Drive();
    }

    // Define the derived interface 'IRaceable' that inherits from 'IDriveable'
    interface IRaceable : IDriveable
    {
        void Race();
    }

    //  Implement the 'IRaceable' interface in a class 'SportsCar'
    class SportsCar : IRaceable
    {
        // Implementing Drive() from IDriveable
        public void Drive()
        {
            Console.WriteLine("Driving the sports car.");
        }

        // Implementing Race() from IRaceable
        public void Race()
        {
            Console.WriteLine("Racing the sports car.");
        }
    }
}
