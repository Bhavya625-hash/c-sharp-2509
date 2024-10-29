using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class mathoperation
    {
        static double PI;
        static mathoperation()
        {
            PI = 3.14;
        }
        public void display()
        {
            Console.WriteLine($"value of PI is:{PI}");
        }
    }
}
