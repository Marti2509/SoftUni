USE Bank
GO

CREATE TABLE NotificationEmails
(
	Id INT NOT NULL IDENTITY
   ,Recipient INT NOT NULL
   ,[Subject] VARCHAR(MAX) NOT NULL
   ,Body VARCHAR(MAX) NOT NULL
   ,CONSTRAINT PK_Id
   PRIMARY KEY (Id)
)

CREATE TRIGGER tr_AddToNotificationEmails
ON Logs FOR INSERT
AS 
	INSERT INTO NotificationEmails
	SELECT AccountId
		  ,CONCAT('Balance change for account: ', AccountId)
		  ,CONCAT('On ', GETDATE(), 'your balance was changed from ', OldSum, ' to ', NewSum, '.')
	  FROM inserted
GO