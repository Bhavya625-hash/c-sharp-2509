using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class bank
    {
       public static double interestrate;
        public int Balance;
        public int Acctnumber;

        static bank()
        {
            interestrate = 3.5;
           
        }
        public bank (int balance,int acctnumber)
        {
          Balance= balance; 
          Acctnumber= acctnumber;
          double Amount = Balance +(Balance * interestrate/100);
          Console.WriteLine($"{Amount} is remaining balance");
        }
      



    }
}
