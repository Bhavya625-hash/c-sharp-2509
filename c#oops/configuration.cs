using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class configuration
    {
       
        public static string ApplicationName;

        
        public string UserPreference;

       
        static configuration()
        {
            ApplicationName = "My Application";  
            Console.WriteLine("Static constructor : Application " + ApplicationName);
        }

       
        public configuration(string userPreference)
        {
            UserPreference = userPreference; 
            Console.WriteLine("Instance constructor: User Preference  " + UserPreference);
        }

        
        public void Displayconfiguration()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
            Console.WriteLine($"User Preference: {UserPreference}");
        }
    }
}
