using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
   public class Greet
    {
        public delegate void GreetDelegate(string message);
        //delegate declaration
        public GreetDelegate greet = delegate (string msg)
        {
            Console.WriteLine(msg);
        };
        //anonymous method
    }
}
