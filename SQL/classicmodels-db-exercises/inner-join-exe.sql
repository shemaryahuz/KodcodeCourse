-- Inner Join
USE classicmodels;

-- 1. Show each order and its customer name
SELECT o.orderNumber, c.customerName
FROM orders o
INNER JOIN customers c ON o.customerNumber = c.customerNumber;

-- 2. Show employees and their offices city
SELECT e.firstName, e.lastName, o.city
FROM employees e
INNER JOIN offices o ON e.officeCode = o.officeCode;

-- 3. Show order details with product names
SELECT
od.orderNumber,
p.productName,
od.quantityOrdered
FROM orderdetails od
INNER JOIN products p ON od.productCode = p.productCode;

-- 4. Show customer names with their sales reps'names
SELECT
c.contactFirstName,
c.contactLastName,
e.firstName,
e.lastname
FROM customers c
INNER JOIN employees e ON c.salesRepEmployeeNumber = e.employeeNumber;
