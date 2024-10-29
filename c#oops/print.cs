using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class print
    {
        public void printData(string data)
        {
            Console.WriteLine("String: " + data);
        }

        public void printData(int data)
        {
            Console.WriteLine("Integer: " + data);
        }


        public void printData(int[] data)
        {
            Console.Write("Array of integers: ");
            foreach (int num in data)
            {
                Console.Write(num + " ");
            }

        }
    }
}
