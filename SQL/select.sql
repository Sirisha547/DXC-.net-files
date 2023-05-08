use Northwind
select * from employees

select * from Products

select * from customers

select companyname, contactname, contacttitle,city from customers

select * from customers where city='Berlin'

select * from customers where customerid='BOLID'

select * from customers where ContactTitle='Marketing Manager' 

select * from products where unitsinstock>50

select * from customers where City='hyderabad' or City='berlin'

select * from customers where city='barcelona' and country='spain'

select * from customers where Region is not null

select * from customers where not Region is null

select * from customers where Region is null

select * from customers where not city='London'

Select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as Amount,
(UnitPrice*UnitsInStock)*10/100 as Discount from Products

Select * from Products where ProductID not between 11 and 20

Select * from Customers where City='London' or City='Madrid' or City='Paris' or City='Berlin'

Select * from Customers where City in ('London', 'Madrid', 'Paris', 'Berlin')

Select * from Customers where ContactName like 'A%'

Select * from Customers where ContactName like 'A_'

Select * from Customers where ContactName like '[ASJ]%'

Select * from Customers where ContactName like 'A%S'

Select top 5 * from Customers

Select * from Customers Order By ContactName Desc

Select * from Customers

Select * from Customers Order By CustomerID offset 50 rows fetch next 7 rows only

Select distinct ContactTitle from Customers