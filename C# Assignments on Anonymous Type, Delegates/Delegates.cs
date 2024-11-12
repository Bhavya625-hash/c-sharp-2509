using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
    public class Delegates
    {
        public delegate void OperationDelegate(double num1,double num2);
        //delegate declaration
        public static void Addition(double firstnumber,double secondnumber)
        {
            Console.WriteLine("sum is:"+(firstnumber+secondnumber));
        }
        // addition method
        public static void Subtraction(double firstnumber,double secondnumber)
        {
            Console.WriteLine("Difference is" +(firstnumber-secondnumber));
        }
        //subtraction method
        public static void Division(double firstnumber,double secondnumber)
        {
            if (secondnumber != 0)
            {
                Console.WriteLine("Quotient is" + (firstnumber / secondnumber));
            }
            else
            {
                Console.WriteLine("invalid");
            }
           
        }
        public static void Multiplicationn(double firstnumber,double secondnumber)
        {
            Console.WriteLine("product is"+(firstnumber*secondnumber));
        }
    }
}
