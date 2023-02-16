USE Bank
GO

CREATE PROC usp_WithdrawMoney
		@AccountId INT
	   ,@MoneyAmount DECIMAL(18, 4)
AS
	BEGIN TRANSACTION
		UPDATE Accounts
		   SET Balance = Balance - @MoneyAmount
		 WHERE Id = @AccountId
	BEGIN
	COMMIT
	END
GO

EXEC dbo.usp_WithdrawMoney 5, 25.0000
SELECT *
  FROM Accounts
 WHERE Id = 5