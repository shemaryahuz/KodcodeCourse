USE classicmodels;
-- FUNCTIONS

-- COUNT
SELECT productVendor, COUNT(*)
FROM products
GROUP BY productVendor;

SELECT status, COUNT(*)
FROM orders
GROUP BY status;

SELECT officeCode, COUNT(*)
FROM employees
GROUP BY officeCode;

SELECT salesRepEmployeeNumber, COUNT(*)
FROM customers
GROUP BY salesRepEmployeeNumber;

SELECT productScale, COUNT(*)
FROM products
GROUP BY productScale;

-- AVERAGE
SELECT salesRepEmployeeNumber, AVG(creditlimit)
FROM customers
GROUP BY salesRepEmployeeNumber;

SELECT productVendor, AVG(buyPrice)
FROM products
GROUP BY productVendor;

-- MIN & MAX
SELECT country, MIN(creditLimit), MAX(creditLimit)
FROM customers
GROUP BY country;

-- ORDER BY DESC
SELECT customerNumber, AVG(amount) as avg
FROM payments
GROUP BY customerNumber
ORDER BY avg DESC;

-- MAX & COUNT
SELECT orderDate, COUNT(*) as count
FROM orders
GROUP BY orderDate
ORDER BY count DESC;