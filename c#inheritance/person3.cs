using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
   public class person3
    {
        public string Name { get; set; }

        public person3(string name)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Person Name: {Name}");
        }
    }

    // Step 2: Create the derived class 'Student' and hide the Name property
    public class Student : person3
    {
        public new string Name;

        public Student(string personName, string studentName) : base(personName)
        {
            Name = studentName;
        }

        public void ShowNames()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Base Person Name: {base.Name}"); 
        }

    }
}
