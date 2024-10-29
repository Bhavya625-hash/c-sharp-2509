using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    public class person1
    {
        public string Name;

        public person1(string name)
        {
            Name = name;
            Console.WriteLine("Person");
        }
    }

   
    class Employee : person1
    {
        public int EmployeeId;

       
        public Employee(string name, int employeeId) : base(name)
        {
            EmployeeId = employeeId;
            Console.WriteLine("Employee ");
        }
    }
}
