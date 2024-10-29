using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public class Employee
    {
        static int totalEmployees;

        public Employee()
        {
            totalEmployees++;
        }
        public static void DisplayEmployee()
        {
            Console.WriteLine($"Total Employees :{totalEmployees}");
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("I am a Employee");
        }
    }
    public class  Manager:Employee
    {
        public override void ShowDetails()
        {
            Console.WriteLine("I am a Manager");
        }
    }
    public class Developer: Employee
    {
        public override void ShowDetails()
        {
            Console.WriteLine("I am a Developer");
        }
    }
}

