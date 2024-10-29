create table sales(
salesID int not null primary key,
productID int,
productname varchar(255),
quantitysold int,
saleamount int,
saledate date
);
select *from sales
drop table sales


insert into sales(salesID,productID,productname,quantitysold,saleamount,saledate)
values
(1,101,' Laptop', 5, 5000,' 2024-09-01'),
(2,102,' Mouse', 10 ,250,' 2024-09-02'),
(3,101,' Laptop', 3 ,3000 ,'2024-09-03'),
(4,103 ,'Keyboard', 8 ,800 ,'2024-09-04'),
(5,102,' Mouse', 6, 150,' 2024-09-05')
select sum(saleamount)as sum  from sales
select max(quantitysold)as max from sales
select avg(saleamount)as avg from sales
select min(saleamount) as min from sales
select sum(quantitysold) as sum from sales where productname='Laptop'

--2 Employee Salaries
create table Employeetable(
EmployeeID int not null primary key,
EmployeeName varchar(50),
Department varchar(50),
Salary int,
HireDate date
);
select * from Employeetable
insert into Employeetable(EmployeeID,EmployeeName,Department,Salary,HireDate)
values
(1,'John Doe','IT', 5000,'2022-01-10'),
(2,'Jane Smith','HR', 6000,'2021-03-15'),
(3,'Bob Johnson','Finance', 5500,'2020-06-20'),
(4,'Alice Brown','IT', 6200,'2023-02-01'),
(5,'Charlie White','Marketing', 4800,'2023-03-10')
truncate table Employeetable
drop table Employeetable
select sum(salary) as expenditure from Employeetable
select max(salary) as highestsalary from Employeetable
select avg(salary) as avg from Employeetable
select min(salary) as minsalary from Employeetable where Department ='IT'
select Department,count(Department) as countineachdepartment from Employeetable group by Department order by Department ASC

--3 Inventory Management
create table inventory(
ProductID int not null primary key,
ProductName varchar(50),
QuantityInStock int,
ReorderLevel int,
LastRestockDate date
);
select * from inventory
insert into inventory(ProductID,ProductName,QuantityInStock,ReorderLevel,LastRestockDate)
values
(201,'Monitor',50,10,'2024-08-25'),
(202,'Printer',30,5,'2024-09-01'),
(203,'Mouse',100,15,'2024-09-10'),
(204,'Keyboard',80,20,'2024-09-15'),
(205,'Laptop',25,5,'2024-09-20')
select sum(QuantityInStock) as Quantity from inventory
select max(QuantityInStock) as maxQuantity from inventory
select avg(ReorderLevel) as averagereorderlevel from inventory
select min(ReorderLevel) as minreorderlevel from inventory
select sum(QuantityInstock) as Quantityinstock from inventory where QuantityInStock<ReorderLevel

--4 Customer Orders Database
create table customerorder(
OrderID int not null primary key,
CustomerID varchar(50),
OrderDate date,
OrderAmount int,
QuantityOrdered int
);
select * from customerorder
insert into customerorder(OrderID,CustomerID,OrderDate,OrderAmount,QuantityOrdered)
values
(501,'C001','2024-09-10',1500,3),
(502,'C002','2024-09-11',2000,5),
(503,'C001','2024-09-12',1000,2),
(504,'C003','2024-09-13',2500,4), 
(505,'C002','2024-09-14',3000,6)
select sum(Orderamount) as sum from customerorder
select avg(Orderamount) as avg from customerorder
select max(Orderamount) as max from customerorder
select sum(QuantityOrdered) as total from customerorder
select min(Orderamount) as min from customerorder

--6  Product Ratings Database 
create table productrating(
RatingID int not null primary key,
ProductID varchar(50),
CustomerID varchar(50),
Rating int,
ReviewDate date
);
select * from productrating
insert into productrating(RatingID,ProductID,CustomerID,Rating,ReviewDate)
values
(1,'P001','C001',4,'2024-09-01'),
(2,'P002','C002',5,'2024-09-02'),
(3,'P003','C003',3,'2024-09-03'),
(4,'P004','C004',2,'2024-09-04'),
(5,'P002','C004',4,'2024-09-05')
 select ProductID, avg(Rating) as avg from productrating group by ProductID
 select max(Rating) as max from productrating
 select min(Rating) as min from productrating
 select ProductID,count(Rating) as totalrating from productrating group by ProductID
 select count(distinct productID) as totalratedproducts from productrating

 --Retrieve Employees Who Work in Specific Departments Using IN Operator
select 
from Employee where Department in ('HR','IT','finance')


 -- account
 create table customerdetails(
 customerID int not null primary key,
 accountno int,
 name varchar(255),
 address varchar(255),
 accounttype varchar(255)
 );
 select * from customerdetails
 insert into customerdetails(customerID,accountno,name,address,accounttype)
 values
 (1,123,'ravi','kochi','savings'),
 (2,124,'michael','tsr','current'),
 (3,125,'ann','ekm','current'),
 (4,126,'sara','kollam','savings')

 alter table customerdetails
 add constraint FK_customerdetails foreign key (customerID)
 references customerdetails(customerID)
 go

 CREATE TABLE Student (      
  id int PRIMARY KEY ,     
  admission_no varchar(45) NOT NULL,  
  first_name varchar(45) NOT NULL,      
  last_name varchar(45) NOT NULL,  
  age int,  
  city varchar(25) NOT NULL      
);    
CREATE TABLE Fee (   
  admission_no varchar(45) NOT NULL,  
  course varchar(45) NOT NULL,      
  amount_paid int,    
);  
select * from Student
select * from Fee
insert into student(id,admission_no,first_name,last_name,age,city)
values
(1,2234,'ann','k',13,'tokyo'),
(2,2345,'amal','joy',15,'rome'),
(3,2456,'amen','mathew',17,'berlin'),
(4,2378,'joyal','peter',19,'rio'),
(5,2567,'paul','walker',22,'lisbon'),
(6,2365,'ram','kumar',21,'germany'),
(7,3472,'suresh','s',20,'italy'),
(8,2765,'rohan','roy',24,'japan')
insert into Fee(admission_no,course,amount_paid)
values
(2234,'java',20000),
(2345,'python',22000),
(2456,'sql',18000),
(2378,'ml',30000),
(2567,'c',10000)
select student.id,student.admission_no,student.first_name,student.last_name,Fee.course,Fee.course,Fee.amount_paid from student
inner join Fee
on student.admission_no =Fee.admission_no
select student.id,student.admission_no,student.first_name,student.last_name,Fee.course,Fee.course,Fee.amount_paid from student
left outer join Fee
on student.admission_no =Fee.admission_no
select student.id,student.admission_no,student.first_name,student.last_name,Fee.course,Fee.course,Fee.amount_paid from student
right outer join Fee
on student.admission_no =Fee.admission_no
select student.id,student.admission_no,student.first_name,student.last_name,Fee.course,Fee.course,Fee.amount_paid from student
full outer join Fee
on student.admission_no =Fee.admission_no
drop table Student
drop table Fee

-- Add a New Column 
select * from Employeetable
 ALTER TABLE Employeetable
ADD DOB date; 

--Modify Column Data Type 

create table customertable(
custumerID int not null primary key,
customername varchar(255),
phonenumber int
);
insert into customertable(custumerID,Customername,phonenumber)
values
(1,'raju',56789),
(2,'ramu',45670)
select * from customertable
alter table customertable
alter column phonenumber varchar(15)

--Add a Primary Key 
create table department(
 
departmentID int not null,
departmentname varchar(50)
);
select * from department
drop table department

alter table department
add constraint pk_department PRIMARY KEY(departmentID)

-- Drop a Column
alter table Employeetable
drop column DOB
select * from Employeetable

--Add a Foreign Key 
create table orders(
orderID int NOT NULL PRIMARY KEY,
ordername varchar(255)
);
alter table Employeetable
ADD CONSTRAINT FK_Employeetable
foreign key(EmployeeID)
references orders(orderID)
DROP TABLE ORDERS
--dropping foreign key
ALTER TABLE Employeetable
DROP CONSTRAINT FK_EmployeeID; 

-- Rename a Column 
EXEC sp_rename 'Employeetable.EmployeeName', 'EmployeeFullName', 'COLUMN'; 

--Adding a Default Constraint 
ALTER TABLE Employeetable 
add status varchar(255) default 'active'
update Employeetable
set status='active'

--Adding a Unique Constraint 
alter table Employeetable
add Email varchar(50)

--Add a Check Constraint
alter table Employeetable
add constraint ck_salary check (salary>1000)

-- Drop a Check Constraint 
alter Employeetable
drop constraint ck_salary

--subqueries
--1
create table Employees(
EmployeeID int,
Employeename varchar(50),
salary int
);
select * from Employees
insert into Employees(EmployeeID,Employeename,salary)
values
(1,'raju',3000),
(2,'ramu',4000),
(3,'ram',5000)
select Employeename, salary
from employees
where salary > (select AVG(salary) from employees);

--2
create table Employeenew(
EmployeeID int not null primary key identity,
Employeename varchar(255),
DepartmentID int
);
select * from Employeenew
select * from department
insert into department(departmentID,departmentname)
values
(1,'HR'),
(2,'marketing')
insert into Employeenew(Employeename,DepartmentID)
values
('ravi',1),
('ramu',2),
('ram',1),
('ranj',1),
('raj',1),
('sonu',1),
('amal',1)
select departmentname from department where departmentID in(select departmentID from Employeenew group by departmentID having count(EmployeeID)>5)

--3  
create table products(
productID int not null identity,
productname varchar(255),
categoryname varchar(255) not null,
stock int not null,
price int not null
);
select * from products
drop table products
insert into products
values
('pen','stationary',10,4000),
('pencil','stationary',10,3000)
select productname,price from products where price>(select max(price) from products where categoryname ='stationary')

--4 Employees (EmployeeID, EmployeeName, Salary, DepartmentID) 
 --Departments (DepartmentID, DepartmentName)
select * from Employee
select * from department
select departmentname from department where departmentID in (select departmentID FROM Employee group by departmentID having count(EmployeeId)>5) 

--6
select * from customers
insert into customers(customerID,customername,phonenumber)
values
(1,'amul',9345),
(2,'amam',2345),
(3,'appu',3267)
select * from orders
drop table orders
create table orders(
orderID int not null,primary key,
customerID int not null,
customername varchar(255)
);

select customername from customers where customerID not in (select customerID from orders)

--7

--8
select * from products
select * from orderdetails
insert into orderdetails(orderID,productID,quantity)
values
(1,3,200),
(2,4,400)
select productname from products where productID NOT IN (select productID from orderdetails)

--1 
insert into Employeenew(EmployeeID,Employeename,salary,departmentID,managerID)
values
(1,'john',40000,1,4),
(3,'david',55000,2,4),
(4,'jane',60000,1,1),
(6,'ann',45000,0,1)
create table Employeenew(
EmployeeID int not null,
Employeename varchar(255),
salary int,
departmentID int,
managerID int
);
insert into department
values
(3,'finance')
select * from department
select * from Employeenew


SELECT Employeenew.EmployeeName,department.departmentname FROM Employeenew INNER JOIN department ON Employeenew.departmentID = department.departmentID

--2 
select * from department
select * from Employeenew

SELECT Employeenew.Employeename,department.departmentname FROM Employeenew LEFT JOIN department ON Employeenew.departmentID = department.departmentID

--3
select * from department
select * from Employeenew

select Employeenew.Employeename,department.departmentname from Employeenew RIGHT join department on Employeenew.DepartmentID=department.departmentID

--4

select Employeenew.Employeename,department.departmentname from Employeenew FULL OUTER join department on Employeenew.DepartmentID=department.departmentID

--9 (self join)
select E1.Employeename,E2.Employeename as manager from Employeenew E1 inner join Employeenew E2 on E1.managerID =E2.EmployeeID

--5 Retrieve Orders and the Customers Who Placed Them (INNER JOIN) 
-- Retrieve order IDs and customer names for all orders.

insert into orders(orderID,customerID,amount)
values
(11,1,274),
(12,1,876),
(13,3,654)
select * from customers
select * from orders
select orders.orderID, Customers.Customername from orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID
--6 Retrieve Orders and Customers, Including Customers Without Orders
select customers.customername, orders.orderID from customers LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
--7 Retrieve Products and Their Categories (INNER JOIN) 
select * from product
select * from categories
insert into product(productID,productname,price,categoryID)
values
(1,'laptop',500,2),
(2,'mouse',20,1),
(3,'keyboard',30,2),
(4,'printer',150,1)
insert into categories(categoryID,categoryname)
values
(1,'A'),
(2,'B'),
(3,'C'),
(4,'D')
select * from product
select * from categories
SELECT product.productname, categories.categoryname FROM Product INNER JOIN Categories ON Product.categoryID = categories.categoryID

--8 Retrieve All Categories and Products, Including Categories Without Products (RIGHT JOIN)
select * from product
select * from categories
SELECT Categories.CategoryName, Product.ProductName FROM Product RIGHT JOIN Categories ON Product.CategoryID = Categories.CategoryID

--10 Get All Possible Combinations of Products and Orders (CROSS JOIN) 
select * from product
select * from orders

SELECT Product.ProductName, Orders.OrderID FROM Product CROSS JOIN Orders

--GROUP BY and HAVING clauses

--1
select * from Employeenew
select * from department
create table Employee2(
Employee
select d.departmentname, avg(E.salary) as averagesalary from Employeenew group by d.departmentname having avg(E.salary) > 50000

--2
--SELECT d.departmentName,COUNT(E.EmployeeID) AS EmployeeCount FROM Employees E join  departments d ON e.departmentID = d.departmentID GROUP BY  d.departmentName HAVING COUNT E.EmployeeID) > 5;

--3 Find the Maximum and Minimum Salary in Each Department 

--select * from department
--select d.departmentName,MAX(e.Salary) AS MaxSalary, MIN(e.Salary) AS MinSalary FROM Employees e JOIN departments d ON e.departmentID = d.departmentID GROUP BY d.departmentName HAVING  MIN(e.Salary) > 30000;

--4 Find the Total Sales by Each Salesperson 
--SELECT e.EmployeeName,SUM(s.SaleAmount) AS TotalSales FROM Employees e JOIN Sales s ON e.EmployeeID = s.EmployeeID GROUP BY e.EmployeeName HAVING SUM(s.SaleAmount) > 100000;

--5 Find the Number of Orders by Each Customer
--select * from orders SELECT c.CustomerName,COUNT(o.OrderID) AS OrderCount FROM  Customers c JOIN Orders o ON c.CustomerID = o.CustomerID GROUP BY c.CustomerName HAVING COUNT(o.OrderID) > 3;
