-- SQL Server uses schemas to logically groups tables and other database objects. 
-- In our sample database we have two schemas: sales and production.
SELECT first_name, last_name
FROM sales.customers

-- The result of a query is called a result set.
SELECT first_name, last_name, email
FROM Sales.customers

-- To get data from all table columns, you can specify all the columns in the select list.
-- You can also use SELECT * as a shorthand to save some typing
SELECT *
FROM sales.customers;

-- To filter rows based on one or more condition, you use a WHERE clause
SELECT *
FROM sales.customers
WHERE state = 'CA';

-- To sort the result set based on one or more columns, you use the ORDER BY clause as shown in the following example:
-- FROM -> WHERE -> SELECT -> ORDER BY
SELECT *
FROM sales.customers
WHERE state = 'CA'
ORDER BY first_name

-- To group rows into groups, you use the GROUP BY clause.For example the following statement
-- returns all the cities of customers located in California and the number of customers in each city
-- FROM -> WHERE -> GROUP BY -> SELECT -> ORDER BY
SELECT city,COUNT(*)
FROM sales.customers
WHERE state = 'CA'
GROUP BY city
ORDER BY city;

-- sql server select - filter groups example
-- To filter groups based on one or more conditions, you use the HAVING clause. The following example returns the city in california which has more than ten customes
SELECT city, COUNT(*)
FROM sales.customers
WHERE state = 'CA'
GROUP BY city
HAVING COUNT(*) > 10
ORDER BY city;

SELECT first_name, COUNT(*)
FROM sales.customers
WHERE state = 'NY'
GROUP BY first_name
HAVING COUNT(*) > 1
-- Notice that the WHERE Clause filters rows while the HAVING clause filter groups.
-- in this part we learned how to use the SQL Server SELECT statement to query data from a single table.
