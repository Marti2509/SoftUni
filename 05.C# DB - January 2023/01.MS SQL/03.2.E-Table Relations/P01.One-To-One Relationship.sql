USE master
GO

CREATE TABLE Persons
(
	PersonID INT NOT NULL IDENTITY,
	FirstName NVARCHAR(30),
	Salary MONEY,
	PassportID INT NOT NULL
)

CREATE TABLE Passports
(
	PassportID INT NOT NULL,
	PassportNumber VARCHAR(8)
)

ALTER TABLE Persons
ADD CONSTRAINT PK_PersonID
PRIMARY KEY (PersonID)

ALTER TABLE Passports
ADD CONSTRAINT PK_PassportID
PRIMARY KEY (PassportID)

ALTER TABLE Persons
ADD CONSTRAINT FK_Persons_Passports
FOREIGN KEY (PassportID)
REFERENCES Passports(PassportID)

INSERT INTO Passports
VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

INSERT INTO Persons
VALUES
('Roberto', 43300, 102),
('Tom', 56100, 103),
('Yana', 60200, 101)

SELECT FirstName
	  ,Salary
	  ,PassportNumber 
  FROM Persons
  JOIN Passports ON Persons.PassportId = Passports.PassportId