USE classicmodels;
-- CONDITIONS

-- OR
SELECT *
FROM employees
WHERE lastName LIKE 'B%' OR firstName LIKE 'L%';

-- AND
SELECT *
FROM products
WHERE quantityInStock > 100 AND quantityInStock < 500; 

-- NOT
SELECT * FROM customers
WHERE customerNumber NOT BETWEEN 200 AND 300;