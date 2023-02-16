USE Bank
GO

CREATE PROC usp_DepositMoney
		@AccountId INT
	   ,@MoneyAmount DECIMAL(18, 4)
AS
	BEGIN TRANSACTION
		UPDATE Accounts
		   SET Balance = Balance + @MoneyAmount
		 WHERE Id = @AccountId
	BEGIN
	COMMIT
	END
GO

EXEC dbo.usp_DepositMoney 1, 10.0000
SELECT *
  FROM Accounts
 WHERE Id = 1