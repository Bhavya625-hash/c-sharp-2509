using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public struct Circle //value type
    {
        public double Radius { get; set; }  
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public class Shape // reference type
    {
        public double Radius { get; set; }
        public Shape(double radius)
        {
            Radius = radius;
        }
    }
}

