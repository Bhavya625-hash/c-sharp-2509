using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static c__abstract_classes.Vehicle;

namespace c__abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Abstract class
            //Vehicle car = new Car();
            //Vehicle motorcycle = new Motorcycle();

            //car.StartEngine();
            //car.StopEngine();

            //motorcycle.StartEngine();
            //motorcycle.StopEngine();
            //Console.ReadLine(); 

            //2  Virtual Functions
            //Animal Dog = new Dog();
            //Animal Cat = new Cat();

            //Dog.MakeSound(); 
            //Cat.MakeSound();
            //Console.ReadLine();

            //3  Interface
            //IDrive Car = new Cars();
            //IDrive Truck = new Truck();

            //Car.Drive();   
            //Truck.Drive();
            //Console.ReadLine();

            //4  Interface vs. Abstract Class
            //Duck Duck = new Duck();

            //Duck.Fly();      
            //Duck.Swim();     
            //Duck.LayEggs();
            //Console.ReadLine();

            //5  Static Class 
            //int sum = MathOperations.Add(5, 2);
            //int product=MathOperations.Multiply(5, 2);
            //Console.WriteLine(product);
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //6  Extension Methods 
            //int number1 = 4;
            //int number2 = 5;
            //Console.WriteLine(number1.IsEven());
            //Console.WriteLine(number2.IsEven());
            //Console.ReadLine();

            //7  Partial Class 
            //Person person = new Person();
            //person.Name = "Bhavya";
            //person.ShowDetails();
            //Console.ReadLine();

            //8  Partial Methods 
            //Employee employee = new Employee
            //{
            //    Name = "Manu",
            //    HoursWorked = 40,
            //    HourlyRate = 20.50m
            //};


            //employee.DisplaySalary();
            //Console.ReadLine();

            //9  Indexer

            //Book firstboook = new Book("harry potter", "j k rowling");
            //Book secondboook = new Book("Twilight", "stephenie meyer");
            //Book thirdboook = new Book("alice in wonderland", "lewis");
            //Book fourthboook = new Book("peter pan", "j m barbie");
            //Library library = new Library();
            //library[0] = firstboook;
            //library[1] = secondboook;
            //library[2] = thirdboook;
            //library[3] = fourthboook;
            //library.DisplayBooks(library);
            //Console.ReadLine();



            //10  Exception Handling 
            //Console.WriteLine("Enter the numerator:");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the denominator:");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //// Call the Divide method and handle exceptions
            //try
            //{
            //    // Attempt to divide the two numbers
            //    double result = Divide(number1, number2);
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    // Catch and handle the division by zero exception
            //    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    // Catch and handle invalid input formats
            //    Console.WriteLine("Error: Invalid input. Please enter valid integers. " + ex.Message);
            //}
            //finally
            //{
            //    // This block will always execute, regardless of exceptions
            //    Console.WriteLine("End of division operation.");
            //}

            // 11 Enum 
            //Newcar car = new Newcar();
            //car.Display(CarType.verito);
            //Console.ReadLine();

            //12 Attributes

            Type type = typeof(calculator);
            object[] classAttributes = type.GetCustomAttributes(false);
            foreach (DeveloperAttribute attribute in classAttributes)
            {
                Console.WriteLine($"class developer name:{attribute.Name},last modified daate :{attribute.LastModifiedDate}");
            }
            //retrieving method sttribute
            var methodDetail = type.GetMethod("add");
            object[] methodAttribute = methodDetail.GetCustomAttributes(false);
            foreach (DeveloperAttribute attribute in methodAttribute)
            {
                Console.WriteLine($"method developer name:{attribute.Name},last modified daate :{attribute.LastModifiedDate}");
            }
            Console.ReadLine();
        }
    }
}
