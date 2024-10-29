using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class student
    {
        public string Name;
        public int ID;
        private List<double> grades =new List<double>();

        
        public student(string name,int id)
        {
            Name = name;
            ID = id;
            
        }

        public void addGrade(double grade)
        {
            if (grade < 0)
            {
                Console.WriteLine("Enter a valid grade");
            }
            else
            {
                grades.Add(grade);
                Console.WriteLine($"Added grade {grade} for {Name}");
            }
        }
        public void calculateAverage()
        {
            
            double total1 = 0;
            foreach(var item in grades)
            {
            total1 += item;
            }
            double average1=total1/grades.Count;
            Console.WriteLine($"{Name} average mark is {average1}");
            Console.ReadLine();

        }
    }
}
