USE master
GO

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