USE master
GO

CREATE DATABASE Boardgames
GO

USE Boardgames
GO

CREATE TABLE Categories
(
	Id INT NOT NULL IDENTITY
   ,Name VARCHAR(50) NOT NULL
   ,CONSTRAINT PK_Id_Categories
    PRIMARY KEY (Id)
)

CREATE TABLE Addresses
(
	Id INT NOT NULL IDENTITY
   ,StreetName NVARCHAR(100) NOT NULL
   ,StreetNumber INT NOT NULL
   ,Town VARCHAR(30) NOT NULL
   ,Country VARCHAR(50) NOT NULL
   ,ZIP INT NOT NULL
   ,CONSTRAINT PK_Id_Addresses
    PRIMARY KEY (Id)
)

CREATE TABLE Publishers
(
	Id INT NOT NULL IDENTITY
   ,Name VARCHAR(30) NOT NULL UNIQUE
   ,AddressId INT NOT NULL
   ,Website NVARCHAR(40)
   ,Phone NVARCHAR(20)
   ,CONSTRAINT FK_Publishers_Addresses
    FOREIGN KEY (AddressId)
	REFERENCES Addresses(Id)
   ,CONSTRAINT PK_Id_Publishers
    PRIMARY KEY (Id)
)

CREATE TABLE PlayersRanges
(
	Id INT NOT NULL IDENTITY
   ,PlayersMin INT NOT NULL
   ,PlayersMax INT NOT NULL
   ,CONSTRAINT PK_Id_PlayersRanges
    PRIMARY KEY (Id)
)

CREATE TABLE Boardgames
(
	Id INT NOT NULL IDENTITY
   ,Name NVARCHAR(30) NOT NULL
   ,YearPublished INT NOT NULL
   ,Rating DECIMAL(18, 2) NOT NULL
   ,CategoryId INT NOT NULL
   ,PublisherId INT NOT NULL
   ,PlayersRangeId INT NOT NULL
   ,CONSTRAINT PK_Id_Boardgames
    PRIMARY KEY (Id)
   ,CONSTRAINT FK_Boardgames_Categories
    FOREIGN KEY (CategoryId)
	REFERENCES Categories(Id)
   ,CONSTRAINT FK_Boardgames_Publishers
    FOREIGN KEY (PublisherId)
	REFERENCES Publishers(Id)
   ,CONSTRAINT FK_Boardgames_PlayersRanges
    FOREIGN KEY (PlayersRangeId)
	REFERENCES PlayersRanges(Id)
)

CREATE TABLE Creators
(
	Id INT NOT NULL IDENTITY
   ,FirstName NVARCHAR(30) NOT NULL
   ,LastName NVARCHAR(30) NOT NULL
   ,Email NVARCHAR(30) NOT NULL
   ,CONSTRAINT PK_Id_Creators
    PRIMARY KEY (Id)
)

CREATE TABLE CreatorsBoardgames
(
	CreatorId INT NOT NULL
   ,BoardgameId INT NOT NULL
   ,CONSTRAINT PK_CreatorId_BoardgameId_Creators
    PRIMARY KEY (CreatorId, BoardgameId)
   ,CONSTRAINT FK_CreatorsBoardgames_Creators
    FOREIGN KEY (CreatorId)
	REFERENCES Creators(Id)
   ,CONSTRAINT FK_CreatorsBoardgames_Boardgames
    FOREIGN KEY (BoardgameId)
	REFERENCES Boardgames(Id)
)