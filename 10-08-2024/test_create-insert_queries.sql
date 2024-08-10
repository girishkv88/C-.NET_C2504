create database testdb;
use testdb;

--question 1
CREATE TABLE Employees (
EmployeeID INT,
DepartmentID INT,
Salary DECIMAL(10, 2)
);

INSERT INTO Employees (EmployeeID, DepartmentID, Salary)
VALUES (1, 102, 75000.00);
INSERT INTO Employees (EmployeeID, DepartmentID, Salary)
VALUES 
(2, 102, 65000.00),
(3, 103, 85000.00),
(4, 104, 90000.00);


SELECT 
    DepartmentID, 
    AVG(Salary) AS AverageSalary
FROM 
    Employees
GROUP BY 
    DepartmentID;


--Question 2
create database testdb1;
use testdb1;

CREATE TABLE Departments (
DepartmentID INT,
DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
EmployeeID INT,
DepartmentID INT
);

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES
(1, 'Sales'),
(2, 'Marketing'),
(3, 'Finance'),
(4, 'HR');
INSERT INTO Employees (EmployeeID, DepartmentID)
VALUES
(1, 1),
(2, 1),
(3, 3);

SELECT 
    D.DepartmentID, 
    D.DepartmentName
FROM 
    Departments D
LEFT JOIN 
    Employees E ON D.DepartmentID = E.DepartmentID
WHERE 
    E.EmployeeID IS NULL;

--Question 3
CREATE TABLE Customers (
CustomerID INT,
Name VARCHAR(100)
);

CREATE TABLE Orders (
OrderID INT,
CustomerID INT,
OrderDate DATE
);

INSERT INTO Customers (CustomerID, Name)
VALUES
(1, 'Alice Johnson'),
(2, 'Bob Smith'),
(3, 'Carol Brown'),
(4, 'David Wilson');
INSERT INTO Orders (OrderID, CustomerID, OrderDate)
VALUES
(1, 1, '2024-08-01'),
(2, 1, '2024-08-05'),
(3, 2, '2024-08-02'),
(4, 3, '2024-08-03'),
(5, 3, '2024-08-06'),
(6, 3, '2024-08-07');

SELECT 
    C.CustomerID, 
    C.Name, 
    COUNT(O.OrderID) AS OrderCount
FROM 
    Customers C
JOIN 
    Orders O ON C.CustomerID = O.CustomerID
GROUP BY 
    C.CustomerID, C.Name
HAVING 
    COUNT(O.OrderID) > 1;

--question 4
-- Finding the Oldest Employee
SELECT 
    EmployeeID, 
    Name, 
    DateOfBirth
FROM 
    Employees
WHERE 
    DateOfBirth = (SELECT MIN(DateOfBirth) FROM Employees);

-- Finding the Youngest Employee
SELECT 
    EmployeeID, 
    Name, 
    DateOfBirth
FROM 
    Employees
WHERE 
    DateOfBirth = (SELECT MAX(DateOfBirth) FROM Employees);

--Question 5
SELECT 
    CustomerID, 
    COUNT(OrderID) AS TotalOrders, 
    SUM(OrderValue) AS TotalOrderValue
FROM 
    Orders
GROUP BY 
    CustomerID;
