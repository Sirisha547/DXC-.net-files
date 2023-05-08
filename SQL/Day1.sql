Create Database TestDB

Use TestDB

Create Table Customers
(
CustomerId int primary key,
CustomerName varchar(20),
Email varchar(20),
city varchar(20),
Age int
)

Drop Table Customers

create table Orders
(
OrderId int primary key,
OrderDate DateTime,
Amount int,
CustomerId int references Customers(CustomerId) 
)

create table Products
(
ProductId int,
ProductName varchar(20),
Brand varchar(20),
Quantity int,
Price int
)

--adding new column to a table
--Alter table tablename add colnametobeadded datatype

alter table Products add ProductDescription varchar(50)

--removing a column
--alter table tablename drop column colname

alter table Products drop column ProductDescription

--Constraints

alter table Products add constraint check_qty check(Quantity>0)

--adding primary key to the existing table
--alter table tablename alter column colname datatype not null

alter table Products alter column ProductId int not null

--alter table tablename add constraint constraintname primary key colname
alter table Products add constraint pk1 primary key(ProductId)


-- removing check constraint from table
alter table Products drop constraint check_qty

--Dropping foreign key from a table
--alter table tablename drop constarint constraintname

alter table Orders drop constraint fk1

--adding foreign key to a table
--alter table tablename add constraint constraintname foreign key colname references table colname

alter table Orders add constraint fk1 foreign key(CustomerId) references Customers(CustomerId)