using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public partial class Employee
    {
        public string Name;
        public int HoursWorked;
        public decimal HourlyRate;

        // Declaration of partial method
        partial void CalculateSalary();

        public void DisplaySalary()
        {
            CalculateSalary();
        }
    }
}
