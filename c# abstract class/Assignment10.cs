using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public class assignment
    {
        public static double Divide(int number1, int number2)
        {
            // Check for division by zero and throw an exception
            if (number2 == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }

            // Return the result of the division
            return (double)number1 / number2;
        }
    }
}
