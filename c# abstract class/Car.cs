using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public interface IDrive
    {
        
        void Drive();
    }

    public class Cars : IDrive
    {
        // Implement Drive method for Car
        public void Drive()
        {
            Console.WriteLine("Car is driving ");
        }
    }

    public class Truck : IDrive
    {
        // Implement Drive method for Truck
        public void Drive()
        {
            Console.WriteLine("Truck is driving .");
        }

    }
}
