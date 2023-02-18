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