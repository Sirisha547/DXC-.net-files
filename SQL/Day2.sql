use Northwind

--Aggregate Functions
select * from Products

--sum
select sum(unitsinstock) as total from Products
select sum(unitprice) as total from Products

--average
select AVG(unitsinstock) as avg from products
select AVG(UnitPrice) as avg from products

--count
select count(unitprice) as count from products

--min and max
select min(UnitPrice) as min from products
select max(UnitPrice) as max from products

--string functions

select char(90)

select LEFT('sirisha',4)

select RIGHT('sirisha',3)

select LEN('sirisha')

select REVERSE('sirisha')

Select * from Customers
Select LEFT(ContactName, 4) from Customers

Select REVERSE(ContactName) from Customers

--date functions

select getdate()

select DATEADD(dd,5,'2023-05-09')

select DATEDIFF(dd,'2023-05-09','2023-05-29')

select DAY('2023-05-09')
select MONTH('2023-05-09')
select YEAR('2023-05-09')


select * from Orders

select orderdate,DATEADD(dd,5,orderdate) as expecteddate from Orders

--math functions
select power(2,3)

select round(4.467,0)
select round(5.678,0)

select CEILING(9.7)

select FLOOR(97.3)

--group by clause
select * from Products

select supplierid,sum(unitprice) as total from Products group by supplierid

select supplierid,sum(unitprice) as total from Products group by supplierid having supplierid = 7

--joins
select * from customers
select * from Orders
--inner join
select customers.customerid,orderid,companyname,contacttitle,shipaddress,phone from Customers inner join orders on 
customers.customerid=orders.customerid

Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName 
from Customers inner join Orders on Customers.CustomerID=Orders.CustomerID


--left outer join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName 
from Customers left outer join Orders on Customers.CustomerID=Orders.CustomerID

Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName 
from Customers left outer join Orders on Customers.CustomerID=Orders.CustomerID

--right outer join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName 
from Customers right outer join Orders on Customers.CustomerID=Orders.CustomerID

--self join
use Northwind
create table emp
(
	Empid varchar(20),
	EmpName varchar(20),
	MgrId varchar(20)
)

insert into emp values('E001','John','M002'),('E002','James','M003'),('E003','Steve','M001'),
                      ('M001','Peter',NULL),('M002','Maria',NULL),('M003','Bob',NULL)
select * from Emp
select Emp.EmpName, Emp2.EmpName as ReportsTo from Emp inner join Emp as Emp2 on Emp.MgrId = Emp2.EmpId


create table students
(
RollNo int,
StudentName varchar(20),
Marks int
)
insert into students values(1,'John',78),(2,'James',82),(3,'Steve',80),(4,'Peter',91),(5,'Maria',95),
                           (6,'Vishal',65),(7,'Rohit',92),(8,'Vijay',89),(9,'Ajay',85),(10,'Rohit',91)


-- Creating Views
create View ProductDetailsView
as
Select ProductId, ProductName, UnitPrice, UnitsInStock from Products

Select * from ProductDetailsView where UnitPrice>50

--alter views
Alter View ProductDetailsView
as
Select ProductId, ProductName, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as Amount, 
(UnitPrice*UnitsInStock)*10/100 as Discount from Products

Select * from ProductDetailsView

--user defined functions
Create Function square(@num int)
returns int
as
begin
	return square(@num)
end

select dbo.square(5)

--procedurs
-- Stored Procedures

Create Proc ShowCustomers
as
select * from Customers

Exec ShowCustomers

create proc addnewstudent
@rollno int,
@name varchar(10),
@marks int
as
insert into students values(@rollno,@name,@marks)

Exec addnewstudent 11,'Sirisha', 99
 
select * from students




