using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public void settime(int hours, int minutes)
        {
            if (hours >= 0 && hours < 24) 
            {
                Hours = hours;
            }

            else {
                Console.WriteLine("Inavlid hours");
            }
            if(minutes >= 0 && minutes < 60)
            {
                Minutes = minutes;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            
        }
        public void settime(int seconds)
        { 
            if(seconds >= 0 && seconds <86400)
            {
                Hours = seconds / 3600;
                Minutes= (seconds % 3600)/60;
                Seconds = (seconds % 60);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void displaytime()
        {
            Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}");
        }


    }
}
