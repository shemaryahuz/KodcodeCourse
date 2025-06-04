USE classicmodels;
-- SELECT

SELECT *
FROM orders;

SELECT lastName, firstName
FROM employees;

SELECT officeCode
FROM offices;

-- SELECT DISTINCT 
SELECT DISTINCT customerName
FROM customers;

SELECT DISTINCT firstName
FROM employees;

-- WHERE
SELECT *
FROM products
WHERE quantityInStock < 200;

SELECT *
FROM offices
WHERE country='USA';

-- ORDER BY
SELECT *
FROM customers
ORDER BY contactFirstName;

SELECT *
FROM orders
ORDER BY orderDate;