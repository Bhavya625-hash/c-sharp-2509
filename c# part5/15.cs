using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public class FileProcessor
    {
        public void ReadFileContent(string filepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    Console.WriteLine(reader.ReadToEnd());  //using  using will close the file automatically
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file is not found:" + filepath);
            }//handle filenotfoundexception

        }
    }
    public class MathOperations
    {
        public int Divide(int a, int b)
        {
            int quotient = 0;
            try
            {
                quotient = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }//handling dividebyzeroexception
            return quotient;
        }
    }
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("invalid age provided");
        }
    }//invalidageexception custom exception definition
    public class Person
    {
        public int Age { get; set; }
        public void SetAge(int age)
        {
            this.Age = age;
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException();
            }
            Console.WriteLine("your age is" + Age);
        }
    }
}
