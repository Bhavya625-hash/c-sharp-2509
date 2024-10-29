using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    public class Employee1
    {
        public string[] Tasks;
        public Employee1(string[] tasks)
        {
            Tasks = tasks;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Employeedetails:");
            Console.WriteLine("Tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"-{task}");
            }
        }
    }
    //derived class
    public class Maanager : Employee1 
    {
        public Maanager(string[] tasks) : base(tasks) { }
        public override void ShowDetails()
        {
            Console.WriteLine("Maanager details:");
            Console.WriteLine("Tasks");
            foreach(var task in Tasks)
            {
                Console.WriteLine($"-{task}");
            }
            Console.WriteLine("managing");
        }
    }
    //derived developer
    public class Developerr : Employee1
    {
        public Developerr(string[] tasks) : base(tasks) { }
        public override void ShowDetails()
        {
            Console.WriteLine("Tasks:");
            foreach(var task in Tasks)
            {
                Console.WriteLine($"-{task}");
            }
            Console.WriteLine("coding");
        }
    }
}
