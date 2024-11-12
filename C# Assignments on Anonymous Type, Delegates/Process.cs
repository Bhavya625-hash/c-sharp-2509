using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
    public class Process
    {
        public event EventHandler OnCompleted;
        // event declaration
        public void DisplayCounter(int counter)
        {
            for(int i=counter;i>=0;i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            OnCompleted?.Invoke(this, EventArgs.Empty);
            // after completion of counter ,event is invoked
        }
    }
}
