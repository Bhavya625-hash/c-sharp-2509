using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public static class IntExtensions
    {
        // Extension method for int type to check if a number is even
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
