using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public class payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing payment");
        }
    }

    class CreditCardPayment : payment
    {
       
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
            
        }
    }

    class PayPalPayment : payment
    {
        
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
            
        }
    }
}
