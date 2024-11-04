using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
   public class Calculation

    {
        public static void Divide(int number1,int number2,out int Quotient,out int Remainder)
        {
            Quotient = number1 / number2;
            Remainder = number1 % number2;
        }
    }
}
