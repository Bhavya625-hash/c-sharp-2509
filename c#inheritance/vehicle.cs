using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    interface IMovable
    {
        void Move();
    }

    
    interface IRechargeable
    {
        void Recharge();
    }

    class Vehicle : IMovable
    {
        public virtual void Move()
        {
            Console.WriteLine(" vehicle is moving.");
        }
    }

   
    class electriccar : Vehicle, IRechargeable
    {
        public override void Move()
        {
            Console.WriteLine(" electric car is  moving.");
        }

        public void Recharge()
        {
            Console.WriteLine(" electric car is recharging.");
        }
    }
}
