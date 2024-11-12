using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
    public class StringOperation
    {
        public delegate string StringOperationDelegate(string value);
        public static string Upper(string value)
        {
            return value.ToUpper();
        }
        //converts to uppercase
        public static string Reverse(string value)
        {
            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        //returns reverse of the string
        public static string AddPrefix(string value)
        {
            return  string.Concat("Hy"+ value);
        }
        //adds a prefix to the string
    }
}
