--create database countryAndCity
--use countryAndCity

--create table Country(
--Id int primary key identity,
--[Name] nvarchar(50),
--CountryId int unique not null,
--Foreign key (CountryId) REFERENCES City(Id)
--)

--create table City(
--Id int primary key identity,
--[Name] nvarchar(50)
--)

--Insert into Country([Name], CountryId)
--Values
--('Turkey' , 2),
--('China' , 3),
--('France' , 4),
--('Azerbaijan' , 1)

--Select Country.Name , City.Name from Country Join City on City.Id=Country.CountryId



--create table Payment (
--Id int primary key identity,
--payment_id int,
--Foreign key (payment_id) References Customer(Id)
--)

--insert into Payment (payment_id)
--values
--(2),
--(4),
--(1),
--(3)

--insert into Customer ([Name], LastName)
--values
--('Ethan', 'Anderson'),
--('Olivia', 'Martinez'),
--('Liam', 'Robinson'),
--('Ava', 'Carter')


--create table Customer (
--Id int primary key identity,
--[Name] nvarchar(50),
--LastName nvarchar(50)
--)

--Select Customer.Name , Customer.LastName , Payment.payment_id from Customer Join Payment on Payment.payment_id=Customer.Id

--Select Country.Name , City.Name from Country Right Join City on City.Id=Country.CountryId


--Create table Employee(
--first_name nvarchar(50),
--last_name nvarchar(50),
--manager_id int)

--insert into Employee(first_name, last_name, manager_id)
--values
--('Ethan', 'Anderson', 134),
--('Olivia', 'Martinez', 12),
--('Liam', 'Robinson', 59),
--('Alexander', 'Hunold', 114),
--('Ava', 'Carter', 50)

--Select * from Employee where first_name='Alexander' and last_name='Hunold' or last_name='Khoo' and manager_id=114

--Alter table Employee
--add Departments nvarchar(50)

--select manager_id from Employee where Departments='IT'