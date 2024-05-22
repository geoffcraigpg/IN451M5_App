USE Northwind;
GO

CREATE PROCEDURE spGetEmployeeCount
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM dbo.Employees;
END;
GO

USE Northwind;
GO

CREATE PROCEDURE spListEmployees
AS
BEGIN
    SELECT *
    FROM dbo.Employees
    ORDER BY LastName ASC;
END;
GO

USE Northwind;
GO

CREATE PROCEDURE spGetOrderCount
AS
BEGIN
    SELECT COUNT(*) AS OrderCount
    FROM dbo.Orders;
END;
GO

USE Northwind;
GO

CREATE PROCEDURE spListOrders
AS
BEGIN
    SELECT *
    FROM dbo.Orders
    ORDER BY OrderDate ASC;
END;
GO