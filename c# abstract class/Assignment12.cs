using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method)]
    class DeveloperAttribute:Attribute  //inheriting from inbuilt class attribute
    {
        public string Name {  get;  }
        public string LastModifiedDate {  get;  }
        public DeveloperAttribute(string name,string lastModifiedDate) 
        {
            Name = name;
            LastModifiedDate = lastModifiedDate;
        }
    }
    [Developer("Bhavya","2024-10-28")] //custom attribute for class
    class calculator
    {
        [Developer("seetha", "2024-10-26")] //custom attribute for method
        public void add(int a, int b)
        {
            Console.WriteLine("sum is :"+(a+b));
        }
    }
}
