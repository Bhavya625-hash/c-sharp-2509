using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public class Device
    {
        public readonly string deviceType;

        public Device(string deviceType)
        {
            deviceType = deviceType;
        }
        public virtual void Operate()
        {
            Console.WriteLine(deviceType + "Device working");
        }
    }
    public class Mouse : Device
    {
        public Mouse() : base("Mouse") { }
        public override void Operate()
        {
            Console.WriteLine("The mouse:");
        }
    }
}
