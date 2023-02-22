-- NOT FINISHED
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