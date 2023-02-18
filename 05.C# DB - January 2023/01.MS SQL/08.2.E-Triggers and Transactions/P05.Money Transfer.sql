USE Bank
GO

CREATE PROC usp_TransferMoney
		@SenderId INT
	   ,@ReceiverId INT
	   ,@Amount DECIMAL(18, 4)
AS
	BEGIN TRANSACTION
		EXEC dbo.usp_WithdrawMoney @SenderId, @Amount
		EXEC dbo.usp_DepositMoney @ReceiverId, @Amount
	BEGIN
		COMMIT
	END
GO

EXEC dbo.usp_TransferMoney 5, 1, 5000
SELECT *
  FROM Accounts
 WHERE Id IN (5, 1)