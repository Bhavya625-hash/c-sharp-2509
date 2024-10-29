using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    interface IPrintable
    {
        void Print();
    }

   
    interface IScannable
    {
        void Scan();
    }


    public class PrinterScanner : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning");
        }
    }   }
