using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public class ExceptionClass

    {
        public int GetUserInput()
        {
            int number;
            while (true)
            {
                try
                {
                    Console.WriteLine("enter an integer");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("you entered an integer");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid entry.enter valid number");
                }
            }
            //prompts the user to enter a valid number
            return number;
        }
    }
}
