using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public enum CarType
    {
        sedan,
        suv,
        verito,
        ferrai
    }
    public class Newcar
    {
        public CarType CarType { get; set; }
        public void Display(CarType type)
        {
            int number = (int)type;
            switch (number)
            {
                case (int)CarType.sedan:
                    Console.WriteLine("this is sedan");
                    break;
                case (int)CarType.suv:
                    Console.WriteLine("this is suv");
                    break;
                case (int)CarType.verito:
                    Console.WriteLine("this is verito");
                    break;
                case (int)CarType.ferrai:
                    Console.WriteLine("this is ferrai");
                    break;

            }
        }
    }
}
