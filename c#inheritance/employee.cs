using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    public class employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    class Manager : employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing the team.");
        }
    }
}
