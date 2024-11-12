using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
    public class  ParallelClass
    {
        public static long Factorial(int number)
        {
            long factorial = 1;
            for(int i=1; i<=number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        //methods to calaculate factorial
    }
}
