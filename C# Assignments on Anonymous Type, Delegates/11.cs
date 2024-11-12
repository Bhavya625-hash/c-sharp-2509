using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
    public class  Async
    {
        public async static void AsyncMethod()
        {
            Console.WriteLine("Async method start");
            await Task.Delay(3000);
            //delay
            Console.WriteLine("Async method end");
        }
        //async method
    }
}
