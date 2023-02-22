USE master
GO

CREATE TABLE Users
(
	Id BIGINT IDENTITY,
	Username NVARCHAR(30) NOT NULL,
	[Password] NVARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX),
	LastLoginTime DATETIME,
	IsDeleted BIT NOT NULL
)

ALTER TABLE Users
ADD CONSTRAINT [PK_Id]
PRIMARY KEY (Id)

INSERT INTO Users
VALUES 
('Marto', 'pass123', NULL, CURRENT_TIMESTAMP, 0),
('Emi', 'pass123', NULL, CURRENT_TIMESTAMP, 1),
('Misho', 'pass123', NULL, CURRENT_TIMESTAMP, 0),
('Mama', 'pass123', NULL, CURRENT_TIMESTAMP, 1),
('Tate', 'pass123', NULL, CURRENT_TIMESTAMP, 0);

SELECT * FROM Users;