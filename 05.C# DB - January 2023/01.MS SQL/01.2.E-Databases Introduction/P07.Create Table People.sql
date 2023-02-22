USE master
GO

CREATE TABLE People
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX),
	Height FLOAT(2),
	[Weight] FLOAT(2),
	Gender CHAR CHECK (Gender = 'm' OR Gender = 'f'),
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX) NOT NULL
)

INSERT INTO People
VALUES 
('Marto', NULL, 173, 53.5, 'm', '2006-09-25', 'HI, This is my biography!'),
('Emi', NULL, 170, 42, 'f', '2004-08-05', 'HI, This is my biography!'),
('Misho', NULL, 150, 27.5, 'm', '2017-03-30', 'HI, This is my biography!'),
('Mama', NULL, 175, 60, 'f', '1983-05-17', 'HI, This is my biography!'),
('Tate', NULL, 185, 85, 'm', '1983-06-01', 'HI, This is my biography!');

SELECT * FROM People;