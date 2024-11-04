using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
   public class Throw
    {
        public static void ValidateAge(int age)
        {
            if (age <= 18)
            {
                throw new ArgumentException("age shuld not be less than 18");//throwing new exception with custom message
            }
            else
            {
                Console.WriteLine("successfully validated your age:");
            }
        }
    }
}
