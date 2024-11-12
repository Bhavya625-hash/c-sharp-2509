using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
    public class TaskClass
    {
        public static async Task<int> CalculateSum(int[] array)
        {
            await Task.Delay(1000);
            //awaits delay
            return array.Sum();
        }
        public static async void Call(int[] numbers)
        {
            int sum=await CalculateSum(numbers);
            Console.WriteLine("sum:"+sum);
        }//calls the calcuatesum method
    }
}
