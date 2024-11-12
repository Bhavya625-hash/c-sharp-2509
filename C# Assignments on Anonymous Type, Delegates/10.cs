using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
   public class Calculation
    {
        public delegate int CalculationDelegate(int x, int y);  //delegate declaration

        public static int Addition(int firstnumber, int secondnumber)
        {
            return firstnumber + secondnumber;
        }
        public static int Subtraction(int firstnumber, int secondnumber)
        {
            return firstnumber - secondnumber;    //method for addition and subtraction
        }
        public static void  Calculate(int firstnumber, int secondnumber,CalculationDelegate calculationDelegate)
        {
            calculationDelegate += Addition;
            int sum=calculationDelegate(firstnumber, secondnumber);
            Console.WriteLine("sum is:"+sum);
            calculationDelegate += Subtraction;
            int diff = calculationDelegate(firstnumber, secondnumber);  
            Console.WriteLine("diff is ;"+ diff);
            // method with two integer and a delegate as a parameter
        }

    }
}
