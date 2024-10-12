
--1  Create a Database and Table 
--Create table Employee(
--EmployeeID int NOT NULL PRIMARY KEY IDENTITY(1,1),
--Firstname varchar(50),
--Lastname varchar(50),
--Department varchar(50),
--salary decimal(10,2)
--);

--2  Insert Data into a Table 
--insert into employee(EmployeeID,Firstname,Lastname,Department,salary)
--values
--(1,'John',' Doe', 'HR', 50000),
-- (2,'Jane', 'Smith',' IT', 60000),
--(3,'David',' Lee',' Marketing', 55000)
  --select *from Employee

--3 Select and Query Data 
--select Firstname,Department from Employee
--select MAX(salary) AS max salary from Employee

--4  Update Data in a Table 
--update Employee
--set salary =55000
--where Firstname='john' 
--set Department='Marketing'
--where Firstname='jane' 

--5  Delete Data from a Table
--delete from Employee
--where EmployeeID =3
--select *from Employee

--6 Product Management 

--Create table products(
--productID int NOT NULL PRIMARY KEY,
--productname varchar(60),
--category varchar(60),
--price int,
--stock int
--);
--select *from products
--insert into products(productID,productname,category,price,stock)
--values
--(1,'Laptop','Electronics',1000,50),
--(2, 'Mouse','Electronics',20,200),
--(3,'keyboard','Electronics',150,75)
--select *from products

--select *from products
--order BY price DESC

--update products
--set price =25
--where productname ='Mouse'
--select *from products

--delete from products
--where productID =2
--select *from products

--select *from products
--order BY productname ASC

--7  Library Management 

--create table Book(
--BookID int NOT NULL PRIMARY KEY,
--Title varchar(50),
--Author varchar(50),
--PublishedYear int,
--Availablecopies int
--);
--select *from Book

--insert into Book(Title,Author,PublishedYear,AvailableCopies)
--values
--(1,'The great gatsby','F.scott fitzgerald',1925,3),
--(2,'1984','george orwell',1949,2),
--(3,'Brave new world','aldous huxley',1932,4)
--select *from Book

--update Book 
--set Availablecopies=5
--where Title ='1984'

--delete from Book
--where PublishedYear>1950

--8  Customer Management
--create table customers(
--customerID int not null primary key,
--customername varchar(60),
--Email varchar(60),
--phonenumber int
--);
--select *from customers
--insert into customers(customerID,customername,Email,phonenumber)
--values
--(1,201, 'Alice Johnson', 'alice@example.com', '555-1234'),
--(2,202, 'Bob Smith', 'bob@example.com','555-5678'),
--(3,203, 'Charlie Brown', 'charlie@example.com', '555-8765')
--INSERT INTO Customers (CustomerID, CustomerName, Email, phonenumber) VALUES
--(4,204, 'David Wilson', 'david@example.com', '555-4321')
--UPDATE Customers
--SET PhoneNumber = '555-9999'
--WHERE CustomerName = 'Alice Johnson';
--DELETE FROM Customers
--WHERE CustomerID = 202;

--9 Orders Management 
--CREATE TABLE Orders (
--    OrderID INT PRIMARY KEY,
--    CustomerID INT,
--    OrderDate DATE,
--    TotalAmount DECIMAL(10, 2),
--    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) 
--);
--select *from Orders
--INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount) VALUES
--(1,301, 201, '2024-09-01', 250.00),
--(2,302, 202, '2024-09-02', 150.00),
--(3,303, 203, '2024-09-03', 200.00);
--INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount) VALUES
--(304, 204, '2024-09-04', 300.00);
--UPDATE Orders
--SET TotalAmount = 275.00
--WHERE OrderID = 301;
--DELETE FROM Orders
--WHERE OrderID = 302;
--SELECT *from Orders
--from Orders
--WHERE TotalAmount > 200.00;
--SELECT OrderID, TotalAmount
--from Orders;

--10 Primary Key 
--create table students(
--studentID int PRIMARY KEY identity(1,1),
--Firstname varchar(255),
--Lastname varchar(255),
--Email varchar(255)
--);
--select *from students
--insert into students(Firstname,Lastname,Email)
--values
--( 'John', 'Doe', 'john.doe@example.com'), 
--( 'Jane', 'Smith', 'jane.smith@example.com'), 
--( 'Mike', 'Johnson', 'mike.johnson@example.com')

--11  Foreign Key 
--create table entrollments(
--entrollmentID int primary key,
--studentID int,
--courseID int
--);
--select *from entrollments
--FOREIGN KEY (studentID) REFERENCES students(studentID),
--FOREIGN KEY (courseID) REFERENCES courses(courseID),

--12  Composite Key 
--create table orderdetails(
--orderID int not null primary key,
--productID int,
--quantity int
--);
--primary key(orderID,productID)

--13  Candidate Key and Alternate Key 
--create table users(
--userID int primary key,
--Email varchar(100) unique,
--username varchar(50)
--);

--14  Surrogate Key 
--create table products(
--AutoID INT primary key identity(1,1),
--productname varchar(255),
--price int
--);

--15 Natural Key 
--create table Employeetable(
--SSN int primary key,
--Firstname varchar(50),
--Lastname varchar(50),
--position varchar(50)
--);

-- 16  Unique Key 
--create table customers(
--customerID int primary key,
--customername varchar(100),
--phonenumber varchar(15) unique
--);
--insert into customers(customerID,customername,phonenumber)
--values

--view
create view EmployeeView
AS
select Firstname,Lastname,Department
from Employee;
select *from Employeeview


create view editableEmployeeView
AS
select EmployeeID,Firstname,Lastname,salary
from Employee;
 --18 update salary
 --update editableEmployeeview
 --set salary=60000
 --where EmployeeID=1
 select * from editableEmployeeview 

 ----19 View with Calculated Columns 
 create view EmployeesalaryBonus as
 select Firstname,Lastname,salary,salary *0.10 as Bonus
 FROM Employee;
 select *from EmployeesalaryBonus;

 --20 Altering a View 
 alter view Employeeview as
 select Firstname,Lastname,Department,salary
 from Employee
 --select *from Employeeview

 --21  View with Parameters (Simulated via Filters) 
 create view FilteredEmployeeview as
 select EmployeeID,Firstname,Lastname,Department
 from Employee
 select *from  FilteredEmployeeview
 where Department ='HR'
  
  --22  Dropping a View 
drop view Employeeview;
select *from Employeeview




