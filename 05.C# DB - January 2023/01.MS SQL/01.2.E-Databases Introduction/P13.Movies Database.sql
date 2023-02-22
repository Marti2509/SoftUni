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