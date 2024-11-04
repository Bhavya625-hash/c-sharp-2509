using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static c__exceptionalhandling.Library;

namespace c__exceptionalhandling
{
  public class Program
    {
        static void Main(string[] args)
        {

            //1  Identify the need for single and multidimensional arrays as  properties of a class
            // Library library = new Library(3);
            //library.AddBook(0, "Book A");
            //library.AddBook(1, "Book B");
            //library.AddBook(2, "Book C");
            //library.DisplayBooks();

            //// Classroom usage
            //Classroom classroom = new Classroom(2, 3);
            //classroom.AssignSeat(0, 0, "Alice");
            //classroom.AssignSeat(0, 1, "Bob");
            //classroom.AssignSeat(1, 0, "Charlie");
            //classroom.DisplaySeatingArrangement();



            //2 . Identify the need for an array of objects 
            //Movie firstmovie = new Movie("deadpool and wovlerine", 2024);
            //Movie secondmovie = new Movie("ARM", 2024);
            //Movie thirdmovie = new Movie("premalu", 2024);
            //Movie fourthmovie = new Movie("twilight saga", 2020);

            //MovieLibrary library = new MovieLibrary();
            //library.Add(firstmovie, 0);
            //library.Add(secondmovie, 1);
            //library.Add(thirdmovie, 2);
            //library.Add(fourthmovie, 3);
            //library.Display();

            //3 identify the need for enumerations
            //Order firstorder = new Order(1, Orderstatus.Pending);
            //Order seccondorder = new Order(1, Orderstatus.Delivered);
            //Order thirdorder = new Order(1, Orderstatus.Shipped);
            //Order.DisplayStatus(firstorder);
            //Order.DisplayStatus(seccondorder);
            //Order.DisplayStatus(thirdorder);




            //4  Identify the need for value types and reference types 

            //circle struct(value type)
            //    Circle circle1 = new Circle(5.0);
            //   Circle circle2 = circle1;//copy of circle1

            //   Console.WriteLine("original circle structs:");
            //    Console.WriteLine($"circle1 radius:{circle1.Radius}");
            //    Console.WriteLine($"circle2  radius:{circle2.Radius}");

            //    //modify circle2
            //    circle2.Radius = 10.0;

            //    Console.WriteLine("\nAfter modifying circle2:");
            //    Console.WriteLine($"circle1 radius:{circle1.Radius}");
            //    Console.WriteLine($"circle2 radius:{circle2.Radius}");

            //    //shape class(reference type)
            //    Shape shape1 = new Shape(5.0);
            //Shape shape2 = shape1; //reference to shape1

            //Console.WriteLine("\nOriginal shape classes:");
            //    Console.WriteLine($"shape1 radius:{shape1.Radius}");
            //    Console.WriteLine($"shape2 radius:{shape2.Radius}");

            //    // modify shape2
            //    shape2.Radius = 10.0;

            //    Console.WriteLine("\nAfter modifying shape2:");
            //    Console.WriteLine($"shape1 radius:{shape1.Radius}");
            //    Console.WriteLine($"cshape2 radius:{shape2.Radius}");

            //5  Identify the need for pass by reference using ref keyword 

            //int playerScore = 8;
            //Console.WriteLine("score at the begining:" + playerScore);
            //Score.IncreasedScore(ref playerScore);
            //Console.WriteLine("current score:" + playerScore);

            // 6  Identify the need for out parameters 

            //int firstnumber = 20;
            //int secondnumber=10;
            //int Quotient;
            //int remainder;
            //Calculation.Divide(firstnumber, secondnumber, out Quotient, out remainder);
            ////now variable quotient has quotient and variable remainder has remainder
            //Console.WriteLine("Quotient:"+Quotient+",Remainder:"+remainder);

            // Assignment 7
            //try
            //{
            //    // IndexOutOfRangeException.
            //    int[] arr = { 1, 2, 3, 4 };
            //    Console.WriteLine(arr[4]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("indexout of range" + ex.Message);
            //}
            //try
            //{
            //    //fileNotFoundException Example
            //    StreamReader reader = new StreamReader("test.txt");
            //    Console.WriteLine(reader.ReadToEnd());

            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("FileNotFoundException caught" + ex.Message);
            //}

            //8 . How to Handle Exception 
            //ExceptionClass exceptionClass = new ExceptionClass();
            //int validnumber = exceptionClass.GetUserInput();
            ////calling fuction
            //Console.WriteLine("valid number is:" + validnumber);

            //9 multiple catch blocks
            //try
            //{
            //    Console.WriteLine("enter the numerator:");
            //    int firstnumber = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter the denominator:");
            //    int secondnumber = Convert.ToInt32(Console.ReadLine());
            //    calculate.Divide(firstnumber, secondnumber);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Division by zero is not possible");
            //}
            //catch
            //{
            //    Console.WriteLine("invalid format");
            //}


            //10 finally block

            //StreamReader reader = null;
            //try
            //{
            //    reader = new StreamReader("bhavya.txt");
            //    Console.WriteLine(reader.ReadToEnd());
            //}
            //catch
            //{
            //    Console.WriteLine("file is not found");
            //}
            //finally
            //{
            //    if (reader != null)
            //    {
            //        reader.Close();
            //    }
            //}

            //11 . Difference between throw and throws 
            //try
            //{
            //    Throw.ValidateAge(27);
            //    Throw.ValidateAge(17);
            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //12. custom exception
            //try
            //{
            //    Check.CheckNumber(8);
            //    Check.CheckNumber(-3);
            //}
            //catch(NegativeNumberException) 
            //{

            //}
            //finally
            //{
            //    Console.WriteLine("code executed");
            //}
            //13 logging exception
            LoggingExample.Divide(10, 0);
            
            //14
            // same as 12

            //15  Explain the Difference between Exception (Checked Exceptions) and RuntimeException(Unchecked Exceptions)
            //FileProcessor processor = new FileProcessor();
            //processor.ReadFileContent("non-existent.txt");
            //MathOperations operations = new MathOperations();
            //operations.Divide(5, 0);
            //try
            //{
            //    Person person = new Person();
            //    person.SetAge(-6);

            //}
            //catch(InvalidAgeException) 
            //{

            //}




            Console.ReadLine();
        }
    }
}
