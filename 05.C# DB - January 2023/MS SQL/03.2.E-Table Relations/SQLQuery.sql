USE master
GO

--	Problem 1
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

--	Problem 2
CREATE TABLE Manufacturers
(
	ManufacturerID INT NOT NULL IDENTITY,
	[Name] VARCHAR(MAX) NOT NULL,
	EstablishedOn DATE,
	CONSTRAINT PK_ManufacturerID
	PRIMARY KEY (ManufacturerID)
)

CREATE TABLE Models 
(
	ModelID INT NOT NULL,
	[Name] VARCHAR(MAX) NOT NULL,
	ManufacturerID INT NOT NULL,
	CONSTRAINT PK_ModelID
	PRIMARY KEY (ModelID),
	CONSTRAINT FK_Models_Manufacturers
	FOREIGN KEY (ManufacturerID)
	REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers
VALUES
('BMW', '07/03/1916'),
('Tesla', '01/01/2003'),
('Lada', '01/05/1966')

INSERT INTO Models
VALUES
(101, 'X1', 1),
(102, 'i6', 1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3)

SELECT ModelID
	  ,ma.[Name]
	  ,mo.[Name]
	  ,EstablishedOn
  FROM Models AS mo
  JOIN Manufacturers AS ma ON mo.ManufacturerID = ma.ManufacturerID

--	Problem 3
CREATE TABLE Students
(
	StudentID INT NOT NULL IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	CONSTRAINT PK_StudentID
	PRIMARY KEY (StudentID)
)

CREATE TABLE Exams
(
	ExamID INT NOT NULL,
	[Name] VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_ExaxID
	PRIMARY KEY (ExamID)
)

CREATE TABLE StudentsExams
(
	StudentId INT NOT NULL,
	ExamID INT NOT NULL,
	CONSTRAINT PK_StudentID_ExamID
	PRIMARY KEY (StudentID, ExamID),
	CONSTRAINT FK_StudentID
	FOREIGN KEY (StudentID)
	REFERENCES Students(StudentID),
	CONSTRAINT FK_ExamID
	FOREIGN KEY (ExamID)
	REFERENCES Exams(ExamID)
)

INSERT INTO Students
VALUES
('Mila'),
('Toni'),
('Ron')

INSERT INTO Exams
VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')

INSERT INTO StudentsExams
VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)

SELECT se.StudentId
	  ,s.[Name]
	  ,se.ExamID
	  ,e.[Name]
  FROM StudentsExams AS se
  JOIN Students AS s ON se.StudentId = s.StudentID
  JOIN Exams AS e ON se.ExamID = e.ExamID
 ORDER BY ExamID

--	Problem 4
CREATE TABLE Teachers
(
	TeacherID INT NOT NULL,
	[Name] VARCHAR(MAX) NOT NULL,
	ManagerID INT
	CONSTRAINT PK_TeacherID
	PRIMARY KEY (TeacherID),
	CONSTRAINT FK_ManagerID_TeacherID
	FOREIGN KEY (ManagerID)
	REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers
VALUES
(101, 'John', NULL),
(102, 'Maya', 106),
(103, 'Silvia', 106),
(104, 'Ted', 105),
(105, 'Mark', 101),
(106, 'Greta', 101)

SELECT * 
  FROM Teachers

-- Problem 5
CREATE DATABASE OnlineStore
GO

USE OnlineStore
GO

CREATE TABLE ItemTypes
(
	ItemTypeID INT NOT NULL IDENTITY,
	[Name] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_ItemTypeID
	PRIMARY KEY (ItemTypeID)
)

CREATE TABLE Items
(
	ItemID INT NOT NULL IDENTITY,
	[Name] NVARCHAR(MAX) NOT NULL,
	ItemTypeID INT NOT NULL,
	CONSTRAINT PK_ItemID
	PRIMARY KEY (ItemID),
	CONSTRAINT FK_Items_ItemTypes
	FOREIGN KEY (ItemTypeID)
	REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
	CityID INT NOT NULL IDENTITY,
	[Name] NVARCHAR NOT NULL,
	CONSTRAINT PK_CityID
	PRIMARY KEY (CityID)
)

CREATE TABLE Customers
(
	CustomerID INT NOT NULL IDENTITY,
	[Name] NVARCHAR(MAX) NOT NULL,
	Birthday DATE,
	CityID INT NOT NULL,
	CONSTRAINT PK_CustomerID
	PRIMARY KEY (CustomerID),
	CONSTRAINT FK_Customers_Cities
	FOREIGN KEY (CityID)
	REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT NOT NULL IDENTITY,
	CustomerID INT NOT NULL,
	CONSTRAINT PK_OrderID
	PRIMARY KEY (OrderID),
	CONSTRAINT FK_Orders_Customers
	FOREIGN KEY (CustomerID)
	REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems
(
	OrderID INT NOT NULL,
	ItemID INT NOT NULL,
	CONSTRAINT PK_OrderID_ItemID
	PRIMARY KEY (OrderID, ItemID),
	CONSTRAINT FK_OrderItems_Items
	FOREIGN KEY (ItemID)
	REFERENCES Items(ItemID),
	CONSTRAINT FK_OrderItems_Orders
	FOREIGN KEY (OrderID)
	REFERENCES Orders(OrderID)
)