--	Problem 1
USE master
GO
CREATE DATABASE Minions
GO

USE Minions
GO

--	Problem 2
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

--	Problem 3
ALTER TABLE Minions
ADD TownId INT NOT NULL;

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)

--	Problem 4
INSERT INTO Towns
VALUES (1, 'Sofia'), 
(2, 'Plovdiv'),
(3, 'Varna');

INSERT INTO Minions
VALUES (1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2);

SELECT * FROM Minions
SELECT * FROM Towns

--	Problem 5
TRUNCATE TABLE Minions;

SELECT * FROM Minions
SELECT * FROM Towns

--	Problem 6
DROP TABLE Minions;
DROP TABLE Towns;

--	Problem 7
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

--	Problem 8
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

--	Problem 9
ALTER TABLE Users
DROP CONSTRAINT PK_Id

ALTER TABLE Users
ADD CONSTRAINT [PK_Id_Username]
PRIMARY KEY (Id, Username)

--	Problem 10
ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordLength CHECK (LEN([Password])>=5);

--	Problem 11
ALTER TABLE Users 
ADD CONSTRAINT DF_Users DEFAULT CURRENT_TIMESTAMP FOR LastLoginTime

--	Problem 12
ALTER TABLE Users
DROP CONSTRAINT PK_Id_Username

ALTER TABLE Users
ADD CONSTRAINT [PK_Id]
PRIMARY KEY (Id)

ALTER TABLE Users
ADD CONSTRAINT CHK_UsernameLength CHECK (LEN([Username])>=3);

INSERT INTO Users
VALUES
('Desi', 'pass123', NULL, CURRENT_TIMESTAMP, 0);

--	Problem 13
USE master
GO
CREATE DATABASE Movies
GO

USE Movies
GO

CREATE TABLE Directors
(
	Id BIGINT NOT NULL IDENTITY,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE Directors
ADD CONSTRAINT [PK_Director_Id]
PRIMARY KEY (Id)

CREATE TABLE Genres
(
	Id BIGINT NOT NULL IDENTITY,
	GenreName NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE Genres
ADD CONSTRAINT [PK_Genre_Id]
PRIMARY KEY (Id)

CREATE TABLE Categories
(
	Id BIGINT NOT NULL IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE Categories
ADD CONSTRAINT [PK_Categories_Id]
PRIMARY KEY (Id)

CREATE TABLE Movies
(
	Id BIGINT NOT NULL IDENTITY,
	Title NVARCHAR(70),
	DirectorId BIGINT NOT NULL,
	CopyrightYear INT NOT NULL,
	[Length] FLOAT(2) NOT NULL,
	GenreId BIGINT NOT NULL,
	CategoryId BIGINT NOT NULL,
	Rating TINYINT,
	Notes NVARCHAR(MAX)
)

ALTER TABLE Movies
ADD CONSTRAINT [PK_Movies_Id]
PRIMARY KEY (Id)

ALTER TABLE Movies
ADD CONSTRAINT [FK_DirectorId]
FOREIGN KEY (DirectorId) REFERENCES Directors(Id)

ALTER TABLE Movies
ADD CONSTRAINT [FK_GenreId]
FOREIGN KEY (GenreId) REFERENCES Genres(Id)

ALTER TABLE Movies
ADD CONSTRAINT [FK_CategoryId]
FOREIGN KEY (CategoryId) REFERENCES Categories(Id)

INSERT INTO Directors
VALUES
('David Lynch', NULL),
('Martin Scorsese', NULL),
('Terrence Malick', NULL),
('Abbas Kiarostami', NULL),
('Errol Morris', NULL);

SELECT * FROM Directors

INSERT INTO Genres
VALUES
('Action', NULL),
('Comedy', NULL),
('Drama', NULL),
('Fantasy', NULL),
('Horror', NULL);

SELECT * FROM Genres

INSERT INTO Categories
VALUES
('18+', NULL),
('16+', NULL),
('14+', NULL),
('12+', NULL),
('10+', NULL);

SELECT * FROM Categories

INSERT INTO Movies
VALUES
('Kill Bill', 3, 2010, 120, 5, 1, NULL, NULL),
('Bang the Drum Slowly', 5, 2015, 180, 3, 2, NULL, NULL),
('The Longest Day', 1, 2020, 70, 2, 5, NULL, NULL),
('Whale Rider', 4, 2021, 90, 4, 4, NULL, NULL),
('Embrace the Serpent', 2, 2022, 105, 1, 3, NULL, NULL);

SELECT * FROM Movies

--	Problem 14
USE master
GO
CREATE DATABASE CarRental
GO

USE CarRental
GO

CREATE TABLE Categories
(
	Id BIGINT NOT NULL IDENTITY,
	CategoryName NVARCHAR(40) NOT NULL,
	DailyRate MONEY,
	WeeklyRate MONEY,
	MonthlyRate MONEY NOT NULL,
	WeekendRate MONEY
)

ALTER TABLE Categories
ADD CONSTRAINT [PK_Categories_Id]
PRIMARY KEY (Id)

CREATE TABLE Cars
(
	Id BIGINT NOT NULL IDENTITY,
	PlateNumber SMALLINT NOT NULL,
	Manufacturer NVARCHAR(40) NOT NULL,
	Model NVARCHAR(30) NOT NULL,
	CarYear SMALLINT NOT NULL,
	CategoryId BIGINT NOT NULL,
	Doors TINYINT,
	Picture VARBINARY(MAX),
	Condition NVARCHAR(20),
	Available BIT NOT NULL
)

ALTER TABLE Cars
ADD CONSTRAINT [PK_Cars_Id]
PRIMARY KEY (Id)

ALTER TABLE Cars
ADD CONSTRAINT [FK_CategoryId]
FOREIGN KEY (CategoryId) REFERENCES Categories(Id)

CREATE TABLE Employees
(
	Id BIGINT NOT NULL IDENTITY,
	FirstName NVARCHAR(25) NOT NULL,
	LastName NVARCHAR(25) NOT NULL,
	Title NVARCHAR(50),
	Notes NVARCHAR(MAX)
)

ALTER TABLE Employees
ADD CONSTRAINT [PK_Employees_Id]
PRIMARY KEY (Id)

CREATE TABLE Customers
(
	Id BIGINT NOT NULL IDENTITY,
	DriverLicenceNumber INT NOT NULL,
	FullName NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(50) NOT NULL,
	City NVARCHAR(30) NOT NULL,
	ZIPCode SMALLINT NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE Customers
ADD CONSTRAINT [PK_Customers_Id]
PRIMARY KEY (Id)

CREATE TABLE RentalOrders
(
	Id BIGINT NOT NULL IDENTITY,
	EmployeeId BIGINT NOT NULL,
	CustomerId BIGINT NOT NULL,
	CarId BIGINT NOT NULL,
	TankLevel TINYINT,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	TotalDays SMALLINT NOT NULL,
	RateApplied TINYINT,
	TaxRate MONEY NOT NULL,
	OrderStatus NVARCHAR(20),
	Notes NVARCHAR(MAX)
)

ALTER TABLE RentalOrders
ADD CONSTRAINT [PK_RentalOrders_Id]
PRIMARY KEY (Id)

ALTER TABLE RentalOrders
ADD CONSTRAINT [FK_EmployeeId]
FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)

ALTER TABLE RentalOrders
ADD CONSTRAINT [FK_CustomerId]
FOREIGN KEY (CustomerId) REFERENCES Customers(Id)

ALTER TABLE RentalOrders
ADD CONSTRAINT [FK_CarId]
FOREIGN KEY (CarId) REFERENCES Cars(Id)

INSERT INTO Categories
VALUES
('Sports Car', NULL, NULL, 15000, NULL),
('Hatchback', NULL, NULL, 8000, NULL),
('Crossover', NULL, NULL, 10000, NULL);

SELECT * FROM Categories

INSERT INTO Cars
VALUES
(1548, 'Audi', 'RS8', 2022, 2, NULL, NULL, NULL, 0),
(6533, 'Tesla', 'Model 3', 2023, 1, NULL, NULL, NULL, 1),
(2489, 'Mazda', 'Model 6', 2019, 3, NULL, NULL, NULL, 1);

SELECT * FROM Cars

INSERT INTO Employees
VALUES
('Marto', 'Simov', 'Boss', NULL),
('Emi', 'Simova', 'Manager', NULL),
('Misho', 'Simov', 'Worker', NULL);

SELECT * FROM Employees

INSERT INTO Customers
VALUES
('53487593', 'Martin Dimitrov Simov', 'Bul. Praga 16', 'Sofia', 1000, NULL),
('68451002', 'Emilia Dimitrova Simova', 'Bul. Praga 16', 'Sofia', 1000, NULL),
('19452620', 'Mihail Milkov Simov', 'Bul. Praga 16', 'Sofia', 1000, NULL);

SELECT * FROM Customers

INSERT INTO RentalOrders
VALUES
(2, 1, 2, 100, 38000, 40000, 2000, '2022-09-25', CURRENT_TIMESTAMP, 100, NULL, 1000, 'READY', NULL),
(3, 2, 1, 70, 20000, 25000, 5000, '2020-12-09', CURRENT_TIMESTAMP, 300, NULL, 3000, 'DRIVING', NULL),
(1, 3, 3, 10, 80000, 90000, 10000, '2023-01-03', CURRENT_TIMESTAMP, 10, NULL, 5000, 'CLEANING', NULL);

SELECT * FROM RentalOrders

--	Problem 15 (not finished!)
USE master
GO
CREATE DATABASE Hotel
GO

USE Hotel
GO

CREATE TABLE Employees
(
	Id BIGINT NOT NULL IDENTITY,
	FirstName NVARCHAR(25) NOT NULL,
	LastName NVARCHAR(25) NOT NULL,
	Title NVARCHAR(60),
	Notes NVARCHAR(MAX)
)

ALTER TABLE Employees
ADD CONSTRAINT [PK_Employees_Id]
PRIMARY KEY (Id)

CREATE TABLE Customers
(
	AccountNumber BIGINT NOT NULL IDENTITY,
	FirstName NVARCHAR(25) NOT NULL,
	LastName NVARCHAR(25) NOT NULL,
	PhoneNumber NVARCHAR(10) NOT NULL,
	EmergencyName NVARCHAR(50) NOT NULL,
	EmergencyNumber NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE Customers
ADD CONSTRAINT [PK_Customers_AccountNumber]
PRIMARY KEY (AccountNumber)

CREATE TABLE RoomStatus
(
	RoomStatus NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE RoomStatus
ADD CONSTRAINT [PK_RoomStatus_RoomStatus]
PRIMARY KEY (RoomStatus)

CREATE TABLE RoomTypes
(
	RoomType NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE RoomTypes
ADD CONSTRAINT [PK_RoomTypes_RoomType]
PRIMARY KEY (RoomType)

CREATE TABLE BedTypes
(
	BedType NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE BedTypes
ADD CONSTRAINT [PK_BedTypes_BedType]
PRIMARY KEY (BedType)

CREATE TABLE Rooms
(
	RoomNumber TINYINT NOT NULL,
	RoomType NVARCHAR(30) NOT NULL,
	BedType NVARCHAR(30) NOT NULL,
	Rate MONEY NOT NULL,
	RoomStatus NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(MAX)
)

ALTER TABLE Rooms
ADD CONSTRAINT [PK_Rooms_RoomNumber]
PRIMARY KEY (RoomNumber)

ALTER TABLE Rooms
ADD CONSTRAINT [FK_RoomType]
FOREIGN KEY (RoomType) REFERENCES RoomTypes(RoomType)

ALTER TABLE Rooms
ADD CONSTRAINT [FK_BedType]
FOREIGN KEY (BedType) REFERENCES BedTypes(BedType)

ALTER TABLE Rooms
ADD CONSTRAINT [FK_RoomStatus]
FOREIGN KEY (RoomStatus) REFERENCES RoomStatus(RoomStatus)

-- TODO: Payments (Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
CREATE TABLE Payments
(
	Id BIGINT NOT NULL IDENTITY,

)

-- TODO: Occupancies (Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)

--	Problem from 16 to 24 NOT STARTED!