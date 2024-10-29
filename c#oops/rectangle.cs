using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class rectangle
    {
        public void rectanglearea(int length, int breadth)
        {
            int area=length*breadth;
            Console.WriteLine($"Area of rectangle is{area}");
        }
        public void rectanglearea(int length)
        {
            int area = length * length;
            Console.WriteLine($"Area of square is{area}");
        }
    }
}
