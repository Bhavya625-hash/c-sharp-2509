using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    public class person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public person2(string name, int age)
        {
            Name = name;
            Age = age;
        }

       
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Step 2: Create the derived class 'Employee'
    public class Emplyee : person2
    {
        public string JobTitle { get; set; }

        public Emplyee(string name, int age, string jobTitle) : base(name, age)
        {
            JobTitle = jobTitle;
        }

        // Overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            // Call the base class method
            base.DisplayInfo();
            
            Console.WriteLine($"Job Title: {JobTitle}");
        }
    }
}
