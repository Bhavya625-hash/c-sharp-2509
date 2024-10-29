using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class car
    {
        private static int carCount;
        public string model;

        static car()
        {
            carCount = 0;
        }
        public car(string model)
        {
           model = model;
           carCount++;
        }
        public static int GetcarCount()
        {
            return carCount;
            
        }
       
    }
}
