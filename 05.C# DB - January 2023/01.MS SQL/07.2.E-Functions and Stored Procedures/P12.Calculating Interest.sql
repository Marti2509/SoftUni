USE Bank
GO

CREATE PROC usp_CalculateFutureValueForAccount
		@accountID INT
	   ,@intrRate FLOAT
AS
	SELECT a.Id AS [Account Id]
		  ,ah.FirstName AS [First Name]
		  ,ah.LastName AS [Last Name]
		  ,a.Balance AS [Current Balance]
		  ,dbo.ufn_CalculateFutureValue(a.Balance, @intrRate, 5) AS [Balance in 5 years]
	  FROM AccountHolders AS ah
	  JOIN Accounts AS a ON ah.Id = a.AccountHolderId
	 WHERE a.Id = @accountID

EXEC dbo.usp_CalculateFutureValueForAccount 1, 0.1