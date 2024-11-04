using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() 
        {
            Console.WriteLine("Negative number is not valid in this context:");
        }

    }
    public class Check
    {
        public static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException();
            }
            else
            {
                Console.WriteLine("valid number entered");
            }
        }
    }
    
}
