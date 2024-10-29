using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1  To demonstrate Polymorphism and its Advantages 
            //shape shape1 = new Circle();   
            //shape shape2 = new Rectangle();

            //shape1.Draw(); 
            //shape2.Draw();
            //Console.ReadLine();

            //2  Method Overloading and its uses 
            //a program=new a();
            //Console.WriteLine( program.Multiply(2, 3));
            //Console.WriteLine( program.Multiply(2, 3, 4));
            //Console.WriteLine( program.Multiply(2.5, 3.5));
            //Console.WriteLine( program.Multiply(2, 3.5));
            //Console.WriteLine( program.Multiply(2.5, 3));
            //Console.ReadLine();

            //3  Method Overriding  
            //vehicle Vehicle = new vehicle();
            //Vehicle.Drive(); 
            //Car Car = new Car();
            //Car.Drive();
            //Console.ReadLine();

            //4 override
            //payment creditCardPayment = new CreditCardPayment();
            //creditCardPayment.ProcessPayment();
            //payment payPalPayment = new PayPalPayment();
            //payPalPayment.ProcessPayment();
            //Console.ReadLine();

            //5 Polymorphism with Static Data and Methods.
            //Manager manager = new Manager();
            //Developer developer = new Developer();
            //manager.ShowDetails();
            //developer.ShowDetails();
            //Employee.DisplayEmployee();
            //Console.ReadLine();

            //6 Polymorphism with Arrays as Properties in a Class 
            //string[] MaanagerTasks = { "Plan project", "Organizing meeting" };
            //string[] DeveloperrTasks = { "coding", "debugging" };
            //Employee1 maanager=new Maanager(MaanagerTasks);
            //Employee1 Developerr=new Developerr(DeveloperrTasks);

            //Console.ReadLine();

            //7 early+late binding
            //overload over = new overload();
            //Console.WriteLine("Early binding:");
            //Console.WriteLine($"int={over.Multiply(3, 4)}");
            //Console.WriteLine($"double ={over.Multiply(6.3, 5.2)}");
            //overrideVehicle car=new overrideVehicle();
            //car.DisplayInfo();
            //Console.ReadLine();

            //8 abstract class+interface
            //Circles circle = new Circles(5);
            //Console.WriteLine($"Area is {circle.CalculateAreass()}");
            //circle.DisplayShape();
            //Console.ReadLine(); 

            //9 multiple inheritance of interfaces
            //Cars cars = new Cars();
            //cars.Move();
            //cars.Draw();
            //Console.ReadLine();

            //10 readonly variable
            Device device = new Device("Compuer");
            device.Operate();
            Mouse mouse = new Mouse();
            mouse.Operate();
            Console.ReadLine();
        }
    }
}
