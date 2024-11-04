using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
     public class Score
    {
        public static void IncreasedScore(ref int score)
        {
            score = score + 10;
            Console.WriteLine("score increased by ten!");
        }
    }
}
