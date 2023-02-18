USE Bank
GO

CREATE PROC usp_GetHoldersWithBalanceHigherThan
		@number MONEY
AS
	SELECT FirstName
	  ,LastName
	  FROM AccountHolders AS ah
	  JOIN Accounts AS a ON ah.Id = a.AccountHolderId
	 GROUP BY ah.Id, FirstName, LastName
	HAVING SUM(a.Balance) > @number
	 ORDER BY FirstName

EXEC dbo.usp_GetHoldersWithBalanceHigherThan 5400