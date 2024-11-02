using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public partial class Employee
    {
        public decimal Salary;

        // Implementation of the partial method
        partial void CalculateSalary()
        {
            Salary = HoursWorked * HourlyRate;
            Console.WriteLine("Employee: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
