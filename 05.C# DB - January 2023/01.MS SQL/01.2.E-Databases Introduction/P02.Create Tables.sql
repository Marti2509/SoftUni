USE Minions
GO

CREATE TABLE Minions
(
	Id INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(100),
	Age INT
)

CREATE TABLE Towns
(
	Id INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(100)
)