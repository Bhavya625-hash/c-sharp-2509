using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 single inheritance
            //person Person = new person("Bhavya", 22);
            //Person.displayperson();
            //student Student = new student("Bhavya", 22, "A");
            //Student.displaystudent();

            //Console.ReadLine();

            // 2 multilevel inheritance
            //Puppy puppy = new Puppy();


            //puppy.Eat();
            //puppy.Bark();
            //puppy.Weep();


            // Console.ReadLine();

            // 3 multiple inheritancce
            //PrinterScanner printerScanner = new PrinterScanner();
            //printerScanner.Print();
            //printerScanner.Scan();
            //Console.ReadLine();

            //4 Hierarchical Inheritance 
            //shape shape = new shape();
            //shape = new Circle();
            //shape.Draw();

            //shape = new Rectangle();
            //shape.Draw();
            //Console.ReadLine();

            //5 hybrid inheritance
            //electriccar Car = new electriccar();

            //Car.Move();
            //Car.Recharge();
            //Console.ReadLine();

            //6 overridiing
            //employee employee = new employee();
            //employee.Work();

            //Manager manager = new Manager();
            //manager.Work();
            //Console.ReadLine();

            //7 Abstract class
            // vehicle1 Car = new Car();
            // vehicle1 Bike = new Bike();

            // Car.Drive();
            // Bike.Drive();
            //Console.ReadLine();

            //8 sealed classes
            //A classA = new A();
            //Console.WriteLine($"sum is:{classA.Add(1, 2)}");
            //Console.ReadLine();

            //9  Constructor Chaining
            //Employee emp = new Employee("Bhavya",5);
            //Console.WriteLine($"Name: {emp.Name}, Employee ID: {emp.EmployeeId}");
            //Console.ReadLine();

            //10  Interface Inheritance 
            //IRaceable myCar = new SportsCar();
            //myCar.Drive();
            //myCar.Race();
            //Console.ReadLine();

            //11 is a relationship
            //Dogs dog = new Dogs("Buddy");
            //dog.Eat();
            //dog.Bark();
            //Console.ReadLine();

            ////12 has a relationship
            //Engine carEngine = new Engine(250);
            //Cars myCar = new Cars("Toyota Supra", carEngine);  // Car "has-a" Engine
            //Console.ReadLine();
            //myCar.ShowCarDetails();

            //13 Calling Base Class Method Using base 
            //Emplyee emp = new Emplyee("ANU", 30, "HR");
            //emp.DisplayInfo();
            // Console.ReadLine();

            //14  Accessing Base Class Variable Using base
            //Student student = new Student("Bhavya", "Bha");
            //student.ShowNames();
            //Console.ReadLine();

            //15  Calling Base Class Constructor Using base 
            Car myCar = new Car("Toyota", "Camry");
            Console.ReadLine();
        }
    }
}
