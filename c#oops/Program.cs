using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class program
    {
        static void Main(string[] args)
        {
            //        try
            //        {
            //            Circle circle = new Circle();
            //            circle.Radius = 5;

            //            Console.WriteLine($"Radius of circle is {circle.Radius}");
            //            Circle circle1= new Circle();
            //            circle1.Radius = -5;
            //            Console.WriteLine($"Radius of circle is {circle1.Radius}");

            //            Console.ReadLine();
            //        }
            //        catch (ArgumentException ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
            //        Console.ReadLine();

            //    }
            //}
            //public class Circle
            //{
            //    private int radius;

            //    public int Radius
            //    {
            //        get { return radius; }
            //        set
            //        {
            //            if (value < 0)
            //            {
            //                throw new ArgumentException("Radius cannot be negative");
            //            }
            //            radius = value;

            //        }


            //2 Employee Class

            //    try
            //    {
            //        Employee employee = new Employee();
            //        employee.Name = "Bhavya";
            //        employee.Salary = 50000;
            //        Console.WriteLine($"Name of employee:{employee.Name},salary:{employee.Salary}");
            //        Employee employee1 = new Employee();
            //        employee1.Name = "Bhavya";
            //        employee1.Salary = -50000;
            //        Console.WriteLine($"Name of employee:{employee1.Name},salary:{employee1.Salary}");
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.ReadLine();
            //}

            //public class Employee
            //{
            //    private string name;
            //    private int salary;
            //    public string Name
            //    {
            //        get { return name; }
            //        set { name = value; }
            //    }
            //    public int Salary
            //    {
            //        get
            //        {
            //            return salary;
            //        }
            //        set
            //        {
            //            if (value < 0)
            //            {
            //                throw new ArgumentException("Negative value cannot be set");
            //            }
            //            salary = value;

            //        }


            //    }
            //}

            //3 Library Management System


            //Library library = new Library();
            //library.AddBook(new Book("1984", "George orwell", "978-0451524935"));
            //library.AddBook(new Book("To Kill a mockingbird", "Harper Lee", "978-04515355935"));
            //library.AddBook(new Book("The great gatsby", "George orwell", "978-0451534467935"));
            //library.DisplayBooks();
            //library.RemoveBook("978-0451534467935");
            //Console.ReadLine();


            //4  Banking System 

            //Bankaccount account = new Bankaccount("123445", "Bhavya", 50000);
            //account.Deposit(2000);
            //account.withdrawal(5000);
            //account.withdrawal(500);
            //Console.ReadLine();

            //5 Student Management System

            //student student1 = new student("Bhavya", 224);
            //student1.addGrade(80);
            //student1.addGrade(30);
            //student1.calculateAverage();


            //6 inventory system

            //try
            //{
            //    item item1 = new item("Laptop", 10, 50000);
            //    item item2 = new item("Mouse", 10, 50000);
            //    item item3 = new item("Keyboard", 10, 50000);
            //    item item4 = new item("Speaker", 5, 10000);

            //    Inventory inventory = new Inventory();
            //    inventory.Add(item1);
            //    inventory.Add(item2);
            //    inventory.Add(item3);
            //    inventory.Add(item4);
            //    inventory.ShowItems();

            //    inventory.RemoveItem("Keyboard");
            //    inventory.ShowItems();
            //    Console.WriteLine();
            //    inventory.UpdateItem("Speaker",10,6000);
            //    inventory.ShowItems();

            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //7 : E-commerce System 
            //try
            //{
            //    product product1 = new product("Bottle", 50, 80);
            //    product product2 = new product("pencil", 50, 80);
            //    product product3 = new product("eraser", 50, 80);

            //    order order = new order();
            //    order.AddProduct(product1);
            //    order.AddProduct(product2);
            //    order.AddProduct(product3);
            //    Console.WriteLine("Before ordering a product");
            //    order.Displayproductdetails("pencil");
            //    order.orderproduct("pencil");
            //    Console.WriteLine("After ordering a product");
            //    order.Displayproductdetails("pencil");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            //8  Print Class 

            //print print = new print();


            //print.printData("Bhavya");


            //print.printData(23);


            //int[] numbers = { 1, 2, 3, 4, 5 };
            //print.printData(numbers);
            //Console.ReadLine();

            //9 Rectangle class

            //rectangle rectangle = new rectangle();
            //rectangle.rectanglearea(4, 5);
            //rectangle.rectanglearea(5);
            //Console.ReadLine();

            ////10 Timer
            //Time time = new Time();
            //time.settime(10, 30);
            //time.displaytime();

            //time.settime(4000);
            //time.displaytime();
            //Console.ReadLine();

            //11 Account
            //bank account1 = new bank(1500, 2456788);
            //Console.WriteLine($"{account1.Acctnumber} account number with {account1.Balance} ");

            //Console.ReadLine();

            //12 car count
            //car car1 = new car("Toyota");
            //car car2 = new car("honda");
            //car car3 = new car("ford");

            //car.GetcarCount();
            //Console.WriteLine($"Total car created:{car.GetcarCount()}");
            //Console.ReadLine();

            //13 initializing constant with static block

            //mathoperation mathoperation = new mathoperation();
            //mathoperation.display();
            //Console.ReadLine();

            //14  Initializing Configuration with Static Constructor 
            //configuration user1 = new configuration("Dark Mode");
            //configuration user2 = new configuration("Light Mode");


            //user1.Displayconfiguration();
            //user2.Displayconfiguration();

            //Console.ReadLine();

            //15 copy constructor
            //person person1 = new person("sachin", 25);
            //Console.WriteLine("person1:");
            //person1.display();
            //person person2 = new person(person1);
            //Console.WriteLine("person 2 (copied using copy constructor);");
            //person2.display();
            //person person3 = person1;

            //person2.Name = "sanju";
            //person2.Age = 30;

            //Console.WriteLine("person1:");
            //person1.display();
            //Console.WriteLine("person2 (after modification);");
            //person2.display();
            //Console.ReadLine();

            //16 chain constructor
            //cars car1 = new cars("Toyota");
            //cars car2 = new cars("Honda", "Civic");
            //cars car3 = new cars("Ford", "Mustang", 2020);
            //cars car4 = new cars("Tesla", "Model S", 2022, 79999.99);


            //car1.DisplayDetails();
            //car2.DisplayDetails();
            //car3.DisplayDetails();
            //car4.DisplayDetails();
            //Console.ReadLine();

            //17  Understanding the Need for Constructor Overloading 
            //product1 product1 = new product1("Basic Product");
            //product1 product2 = new product1("Standard Product", 100.00);
            //product1 product3 = new product1("Premium Product", 200.00, 10.0);


            //product1.DisplayDetails();
            //product2.DisplayDetails();
            //product3.DisplayDetails();

            //Console.ReadLine();

            //18   Exploring Different Ways to Initialize Objects  

            //product2 product1 = new product2("Laptop", 1500.00, "Electronics");
            //Console.WriteLine("Constructor Initialization:");
            //product1.DisplayDetails();

            //// 2. Object Initializer Syntax
            //product2 product2 = new product2 { Name = "Phone", Price = 799.99, Category = "Electronics" };
            //Console.WriteLine("\nObject Initializer Syntax:");
            //product2.DisplayDetails();

            //// 3. Static Factory Method
            //product2 product3 = product2.CreateProduct("Tablet", 399.99, "Electronics");
            //Console.WriteLine("\nStatic Factory Method:");
            //product3.DisplayDetails();

            //// 4. Anonymous Type (no class method can be used)
            //var product4 = new { Name = "Smartwatch", Price = 199.99, Category = "Wearable" };
            //Console.WriteLine("\nAnonymous Type:");
            //Console.WriteLine($"Product Name: {product4.Name}, Price: {product4.Price:C}, Category: {product4.Category}");

            //// 5. Reflection to create an object
            //Type productType = typeof(product2);
            //ConstructorInfo constructorInfo = productType.GetConstructor(new[] { typeof(string), typeof(double), typeof(string) });
            //object product5 = constructorInfo.Invoke(new object[] { "Camera", 549.99, "Photography" });
            //Console.WriteLine("\nReflection Initialization:");
            //((product2)product5).DisplayDetails();

            //// 6. Default Values in Constructor
            //product2 product6 = new product2();
            //Console.WriteLine("\nDefault Values in Constructor:");
            //product6.DisplayDetails();

            //Console.ReadLine();

            //20 shopping cart

            //shoppingcart cart = new shoppingcart();

            //// Add products to the cart
            //cart.AddProduct("Laptop", 1500.00, 1);
            //cart.AddProduct("Mouse", 25.99, 2);
            //cart.AddProduct("Keyboard", 45.50, 1);

            //// Calculate and display the total price
            //double totalPrice = cart.CalculateTotalPrice();
            //Console.WriteLine($"Total Price: {totalPrice:C}");

            //Console.ReadLine();

            //21 nested class
            banks bank = new banks();

            // Add customers to the bank
            bank.AddCustomer("Bhavya");
            bank.AddCustomer("Bharath");

            // Add accounts to customers
            bank.AddAccount("Alice", "123456", 1000.00);
            bank.AddAccount("Alice", "789012", 1500.50);
            bank.AddAccount("Bob", "345678", 2000.00);

            // Display customer details with their accounts
            bank.DisplayCustomerDetails();

            Console.ReadLine();

            //22 
        }

    }
}   



