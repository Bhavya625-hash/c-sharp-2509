using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    public class person
    {
        public string Name;
        public int Age;

        public person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void displayperson()
        {
            Console.WriteLine($"Name;{Name} , Age:{Age}");
        }
    }
    public class student: person   
    {
        public string Grade;
        public student(string name, int age, string grade) : base(name, age)

        {
            Grade = grade;
        }
        public void displaystudent()
        {
            displayperson();
             Console.WriteLine($"Grade:{Grade}");
        }
    }
}


