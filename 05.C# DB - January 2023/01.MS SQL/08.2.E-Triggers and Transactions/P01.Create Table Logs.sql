USE Bank
GO

CREATE TABLE Logs
(
	LogId INT NOT NULL IDENTITY
	,AccountId INT NOT NULL
	,OldSum MONEY NOT NULL
	,NewSum MONEY NOT NULL
	,CONSTRAINT PK_LogId 
	PRIMARY KEY (LogId)
)

CREATE TRIGGER tr_AddToLogs
ON Accounts FOR UPDATE
AS 
	INSERT INTO Logs
	SELECT i.AccountHolderId
		  ,d.Balance
		  ,i.Balance
	  FROM inserted AS i
	  JOIN deleted AS d ON i.Id = d.Id
GO

UPDATE Accounts
   SET Balance = Balance + 10
 WHERE Id = 5