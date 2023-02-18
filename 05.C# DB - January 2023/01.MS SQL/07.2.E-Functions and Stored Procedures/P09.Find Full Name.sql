USE Bank
GO

CREATE PROC usp_GetHoldersFullName
AS
	SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name]
	  FROM AccountHolders

EXEC dbo.usp_GetHoldersFullName