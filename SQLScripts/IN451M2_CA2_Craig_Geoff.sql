USE master;
GO

CREATE LOGIN User_Sales WITH PASSWORD = 'IAmTheSalesRep123';
CREATE LOGIN User_HR WITH PASSWORD = 'IAmTheHRRep123';
CREATE LOGIN User_CEO WITH PASSWORD = 'IAmTheCEO123';

GO

USE Northwind;
GO

CREATE USER User_Sales FOR LOGIN User_Sales;
CREATE USER User_HR FOR LOGIN User_HR;
CREATE USER User_CEO FOR LOGIN User_CEO;
GO


CREATE ROLE SalesRole;
CREATE ROLE HRRole
CREATE ROLE CEORole
GO

GRANT SELECT ON dbo.Orders TO SalesRole;
GRANT EXEC ON dbo.spListOrders to SalesRole;
GRANT EXEC ON dbo.spGetOrderCount to SalesRole;
GRANT SELECT ON dbo.Customers TO SalesRole;
GRANT EXEC ON dbo.spListCustomers to SalesRole;
GRANT EXEC ON dbo.spGetCustomerCount to SalesRole;

GRANT SELECT ON dbo.Employees TO HRRole;
GRANT EXEC ON dbo.spListEmployees to HRRole;
GRANT EXEC ON dbo.spGetEmployeeCount to HRRole;

GRANT SELECT ON dbo.Orders TO CEORole;
GRANT EXEC ON dbo.spListOrders to CEORole;
GRANT EXEC ON dbo.spGetOrderCount to CEORole;
GRANT SELECT ON dbo.Customers TO CEORole;
GRANT EXEC ON dbo.spListCustomers to CEORole;
GRANT EXEC ON dbo.spGetCustomerCount to CEORole;
GRANT SELECT ON dbo.Employees TO CEORole;
GRANT EXEC ON dbo.spListEmployees to CEORole;
GRANT EXEC ON dbo.spGetEmployeeCount to CEORole;
GO

EXEC sp_addrolemember 'SalesRole', 'User_Sales';
EXEC sp_addrolemember 'HRRole', 'User_HR';
EXEC sp_addrolemember 'CEORole', 'User_CEO';
GO
