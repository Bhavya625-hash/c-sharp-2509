using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static C__Assignments_on_Anonymous_Type__Delegates.Calculation;
using static C__Assignments_on_Anonymous_Type__Delegates.Delegates;
using static C__Assignments_on_Anonymous_Type__Delegates.StringOperation;

namespace C__Assignments_on_Anonymous_Type__Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1  Anonymous Types 
            //Create an anonymous type to represent a book with properties for Title, Author, and Price.
            //Display the details of the book.
            //var book = new { Title = "Book", Author = "author", Price = 400 };
            //Console.WriteLine($"Title:{book.Title}\nAuthor:{book.Author}\nPrice:{book.Price}");



            //2 . Var and Dynamic
            //1 Declare a var variable to hold a list of integers, add some numbers to it, and print them. 

            //var numbers= new List<int>();
            ////add some numbers to the list
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);

            ////print the numbers
            //Console.WriteLine("list of numbers");
            //foreach (var number in numbers)
            //{ 
            //    Console.WriteLine(number);
            //}
            //2 Declare a dynamic variable, assign different types of values to it, and observe the  behavior.

            //dynamic value = 100;
            //Console.WriteLine(value.GetType());

            //value = "Bhavya";
            //Console.WriteLine(value.GetType());

            //value =false;
            //Console.WriteLine(value.GetType());

            //3  Delegates 
            // Create a simple calculator using delegates.Define a delegate OperationDelegate that canrepresent different arithmetic operations(addition, subtraction, multiplication, division).
            // Implement methods for each operation and allow the user to select an operation to perform on  two input numbers.


            //Console.WriteLine("enter 1 for addition,2 for subtraction,3 for multiplication,4 for division");
            //int choice=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter two numbers");
            //int firstnumber=Convert.ToInt32(Console.ReadLine());
            //int secondnumber=Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        OperationDelegate firstOperation = new OperationDelegate(Delegates.Addition);
            //        firstOperation(firstnumber, secondnumber);
            //        break;
            //    case 2:
            //        OperationDelegate secondOperation = new OperationDelegate(Delegates.Subtraction);
            //        secondOperation(firstnumber, secondnumber);
            //        break;
            //    case 3:
            //        OperationDelegate thirdOperation = new OperationDelegate(Delegates.Multiplicationn);
            //        thirdOperation(firstnumber, secondnumber);
            //        break;
            //    case 4:
            //        OperationDelegate fourthOperation = new OperationDelegate(Delegates.Division);
            //        fourthOperation(firstnumber, secondnumber);
            //        break;

            // }
            //4 Events 
            //Create an event called OnCompleted in a class Process. Raise the event when a process is 
            //completed.Subscribe to the event from the main program to display a message.

            //Console.WriteLine("Enter a value for the counter");
            //int counter = Convert.ToInt32(Console.ReadLine());
            //Process process = new Process();
            //process.OnCompleted += Process_OnCompleted;
            //process.DisplayCounter(counter);

            //5 Anoymous methods
            //Write a delegate GreetDelegate that takes a string parameter. Assign an anonymous method to 
            //the delegate that prints a greeting message.

            //Greet greetClass= new Greet();
            ////object of great class
            //greetClass.greet("hello,user");
            ////calling anonymous method

            //6  Lambda Expressions 
            // Write a lambda expression that takes two integers and returns their product. Use Func<int, int,
            //int> for the delegate type.

            //Console.WriteLine("Enter two numbers");
            //int firstnumber=Convert.ToInt32(Console.ReadLine());
            //int seccondnumber=Convert.ToInt32(Console.ReadLine());
            //Func<int, int, int> multiply = (x, y) => x * y;
            //Console.WriteLine("product is:"+ multiply(firstnumber, seccondnumber));

            //7 . Expression Tree
            // Create an expression tree for a lambda expression that adds two integers.Compile and execute the expression.

            //Expression<Func<int,int,int>> expression =(a,b) => a + b;
            ////expression tree
            //Console.WriteLine(expression);
            ////outputs the expression

            //var compiledExpression = expression.Compile();
            ////compiles the expression
            //Console.WriteLine("Result:" + compiledExpression(2, 4));

            //8 . Using Delegates to Hold Methods with the Same Signature 
            // Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
            //string.Write three different methods that modify the string in different ways(e.g., convert to
            //uppercase, reverse, add a prefix). Use the delegate to call each method. 

            //StringOperationDelegate stringOperation = new StringOperationDelegate(Upper);
            //string result1 = stringOperation("Bhavya");
            //Console.WriteLine("In uppercase:"+ result1);
            //stringOperation += Reverse;
            //string result2 = stringOperation("Bhavya");
            //Console.WriteLine("reversed string :" + result2);
            //stringOperation += AddPrefix;
            //string result3 = stringOperation("Bhavya");
            //Console.WriteLine( "after adding prefix :"+ result3 );

            //9 Given a list of products with properties Name and Price, use lambda expressions to: 
            // 1.Filter the list to find products that cost more than $50.
            //2.Sort the list by price in descending order. 
            //3.Select and display only the names of products from the filtered list.

            //List<Products> products = new List<Products>();

            //Products products1 = new Products() { Name = "Laptop", Price = 5000 };
            //Products products2 = new Products() { Name = "Mouse", Price = 1000 };
            //Products products3 = new Products() { Name = "pen", Price = 10 };
            //Products products4 = new Products() { Name = "speaker", Price = 5200 };

            //products.Add(products1);
            //products.Add(products2);
            //products.Add(products3);
            //products.Add(products4);

            //var filtered = products.Where(x => x.Price > 50);  //filter accordding to price
            //var ordered =filtered.OrderByDescending(x => x.Price); //order according to price


            //foreach (var item in ordered)
            //{
            //    Console.WriteLine("Name:"+ item.Name+",Price:"+item.Price); //display the filtered and ordered
            //}

            //10 . Delegate as a Callback Mechanism 
            //Create a delegate called CalculationDelegate that takes two integers and returns an integer. 
            //Implement methods for addition and subtraction, and write a method Calculate that accepts two
            //integers and a delegate as parameters.Use the delegate to perform addition and subtraction
            //operations by passing different methods.

            //CalculationDelegate calculation= null;
            //Calculate(4,2,calculation);

            //11 . Introduction to Asynchronous Programming
            // Write a C# program that simulates a long-running operation using Task.Delay() and runs 
            //asynchronously. Display a message before and after the operation completes.

            //Console.WriteLine("Main method start");
            //Async.AsyncMethod();
            ////Calling async method
            //Console.WriteLine("main method end");
            ////this will run even before the completion os async method


            //12  Async and Await Keywords
            //Create a method that downloads data from a sample URL asynchronously.Use HttpClient to
            // fetch the data and print the length of the content.The method should use async and await keywords

            //try
            //{
            //    string url =/* "https://www.w3schools.com/";*/ "www.example.com";
            //    Download.Call(url);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //13 Task and Task<T>
            // Write a C# program that calculates the sum of an array of integers asynchronously using 
            //Task<int>.Return the result from the asynchronous method and display it.

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //TaskClass.Call(numbers);
            //Console.WriteLine("Task running");
            ////even if this is after calling the function,this gets executed first


            //14  Handling Exceptions in Asynchronous Methods 
            // Modify the previous example to handle exceptions that might occur during the sum calculation. 
            // Catch the exception in the Main method and display an error message. 

            //try
            //{
            //    int[] numbers = { 1, 2, 3, 4, 5 };
            //    TaskClass.Call(numbers);
            //    Console.WriteLine("Task running");
            //    //even if this is after calling the function,this gets executed first
            //}
            //catch(Exception )
            //{
            //    Console.WriteLine("An error has occured");
            //}

            //15  Parallel Programming with Task Parallel Library (TPL)
            // Create a program that runs multiple tasks in parallel to simulate multiple operations, such as
            //calculating the factorial of different numbers.Print the result of each task when completed. 

            //int[] numbers = { 1, 2, 3 };
            //Parallel.ForEach(numbers, number =>
            //{
            //    long result=ParallelClass.Factorial(number);
            //    Console.WriteLine("factorial of "+ result);
            //});
            //Console.WriteLine("complete");

            //16 . LINQ Query Syntax and Method Syntax 
            // : Write a LINQ query using both query syntax and method syntax to retrieve all
            //numbers greater than 5 from a list of integers.

            //List<int> numbers = new List<int> { 3, 5, 1, 4, 6, 8, 10, 32, 41, 3, 6 };  //list of integers
            //var results=from number in numbers where number>5 select number;   //query syntax
            //Console.WriteLine("Numbers greater than 5 are:");
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result+" ");
            //}
            ////displaying results
            //var newResults=numbers.Where(x => x > 5);   ///METHOD SYNTAX

            //Console.WriteLine("\nNumbers greater than 5 are:");
            //foreach (var result in newResults)
            //{
            //    Console.Write(result + " ");
            //}
            ////displaying new results


            //17  . LINQ Operators (Select, Where, GroupBy, Join, etc.)
            // Given a list of strings representing student names, write a LINQ query that selects
            //the names starting with the letter 'A' and orders them alphabetically. 

            //List<string> studentNames = new List<string> { "bhavya", "ajna", "karthika", "ammu" };  //list of names
            //var names = studentNames.Where(x => x[0]=='a').OrderBy(x => x);
            ////Selects names starting with A and orders them alphabetically
            //Console.WriteLine("filtered and ordered list");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //18  LINQ to Objects 
            // Write a LINQ query to find the sum of all even numbers in an array of integers.

            //int[] numbers = { 1, 2, 4, 8, 3, 6 };
            //var sumOfEven = numbers.Where(num=> num % 2 == 0).Sum(x=>x);
            //Console.WriteLine("sum of even numbers is :"+sumOfEven);

            //19  LINQ to XML 
            // : Create an XML document representing a list of books, and use LINQ to XML to
            //query the titles of books published after 2015.

            //XDocument xmlDocument= XDocument.Load("C: \\Users\\gulfl\\source\\repos\\C# Assignments on Anonymous Type, Delegates");
            //var books = xmlDocument.Descendants("Book")
            //    .Where(book => (int)book.Element("Year") > 2015)
            //    .Select(book => book.Element("Title").Value);
            //Console.WriteLine("Books published after 2015");
            //foreach(var book in books)
            //{
            //    Console.WriteLine(book);
            //}

            //20 LINQ to SQL 

            //assuming 'db' is an instance of the data context connected to the database
            var itEmployees = from emp in db.Employees 
                              where emp.Department == "IT" 
                              select emp;
            //display result
            foreach(var employee in itEmployees)
            {
                Console.WriteLine($"ID:{employee.ID},Name:{employee.name},Department:{employee.Department}");
            }
            Console.ReadLine();
        }

        private static void Process_OnCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("counter completed");
        }

    }
}
