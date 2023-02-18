USE SoftUni
GO

CREATE PROC usp_GetEmployeesFromTown
		@townName VARCHAR(60)
AS
	SELECT FirstName
		  ,LastName
	  FROM Employees AS e
	  JOIN Addresses AS a ON e.AddressID = a.AddressID
	  JOIN Towns AS t ON a.TownID = t.TownID
	 WHERE t.[Name] = @townName

EXEC dbo.usp_GetEmployeesFromTown 'Sofia'