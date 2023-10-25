--Task 5
CREATE DATABASE CustomerOrder;
USE CustomerOrder;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(255)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2)
);

INSERT INTO Customers (CustomerID, CustomerName) VALUES
(1, 'Customer A'),
(2, 'Customer B'),
(3, 'Customer C');

INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount) VALUES
(101, 1, '2023-10-01', 100.00),
(102, 1, '2023-10-05', 75.50),
(103, 2, '2023-09-20', 200.00),
(104, 3, '2023-10-15', 50.25);

SELECT Customers.CustomerName, Orders.OrderID, Orders.OrderDate, Orders.TotalAmount
FROM Customers
INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;


--Task 4
CREATE DATABASE ComparisonDB;
USE ComparisonDB;

CREATE TABLE TableA (
    ID INT PRIMARY KEY,
    Data VARCHAR(255)
);

CREATE TABLE TableB (
    ID INT PRIMARY KEY,
    Data VARCHAR(255)
);

INSERT INTO TableA (ID, Data) VALUES
(1, 'Record A1'),
(2, 'Record A2'),
(3, 'Record A3'),
(4, 'Record A4');

INSERT INTO TableB (ID, Data) VALUES
(2, 'Record B2'),
(3, 'Record B3'),
(5, 'Record B5'),
(6, 'Record B6');

SELECT TableA.ID, TableA.Data
FROM TableA
right JOIN TableB ON TableA.ID = TableB.ID
WHERE TableB.ID IS NULL;

SELECT TableB.ID, TableB.Data
FROM TableB
LEFT JOIN TableA ON TableB.ID = TableA.ID
WHERE TableA.ID IS NULL;


--Task 3
CREATE DATABASE EmployeeDB;
USE EmployeeDB;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(255),
    JobTitle VARCHAR(255),
    ManagerID INT,
    FOREIGN KEY (ManagerID) REFERENCES Employees(EmployeeID)
);

INSERT INTO Employees (EmployeeID, EmployeeName, JobTitle, ManagerID) VALUES
(1, 'John Smith', 'CEO', NULL),
(2, 'Alice Johnson', 'VP of Operations', 1),
(3, 'Bob Wilson', 'VP of Sales', 1),
(4, 'Eva Davis', 'Manager', 2),
(5, 'Michael Brown', 'Manager', 2),
(6, 'Grace Lee', 'Manager', 3),
(7, 'David Clark', 'Manager', 3),
(8, 'Linda Harris', 'Employee', 4),
(9, 'William Martinez', 'Employee', 5),
(10, 'Karen Hall', 'Employee', 6);

SELECT e.EmployeeName AS Employee, e.JobTitle AS EmployeeJobTitle, 
       m.EmployeeName AS Manager, m.JobTitle AS ManagerJobTitle
FROM Employees e
LEFT JOIN Employees m ON e.ManagerID = m.EmployeeID;


--Task 2
CREATE DATABASE ProductSupplierDB;
USE ProductSupplierDB;

CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY,
    SupplierName VARCHAR(255),
    ContactName VARCHAR(255)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255),
    SupplierID INT,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

INSERT INTO Suppliers (SupplierID, SupplierName, ContactName) VALUES
(1, 'Supplier A', 'John Doe'),
(2, 'Supplier B', 'Jane Smith'),
(3, 'Supplier C', 'Tom Johnson');

INSERT INTO Products (ProductID, ProductName, SupplierID) VALUES
(101, 'Product 1', 1),
(102, 'Product 2', 2),
(103, 'Product 3', 1),
(104, 'Product 4', 3);

SELECT Products.ProductName, Suppliers.SupplierName, Suppliers.ContactName
FROM Products
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID;

-----------------------------------------------------------------------------------
--Task 1
CREATE DATABASE CustomerOrdersDB;
USE CustomerOrdersDB;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(255)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Customers (CustomerID, CustomerName) VALUES
(1, 'Customer A'),
(2, 'Customer B'),
(3, 'Customer C');

INSERT INTO Orders (OrderID, CustomerID, OrderDate) VALUES
(101, 1, '2023-10-01'),
(102, 1, '2023-10-05'),
(103, 2, '2023-09-20'),
(104, 3, '2023-10-15');

INSERT INTO Customers (CustomerID, CustomerName) VALUES
(4, 'Customer D');

SELECT Customers.CustomerID, Customers.CustomerName, Orders.OrderID, Orders.OrderDate
FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY Customers.CustomerID, Orders.OrderID;

