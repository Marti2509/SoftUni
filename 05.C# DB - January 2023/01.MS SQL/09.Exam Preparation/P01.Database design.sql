USE master
GO

CREATE DATABASE Zoo
GO

USE Zoo
GO

CREATE TABLE Owners
(
	Id INT NOT NULL IDENTITY
   ,Name VARCHAR(50) NOT NULL
   ,PhoneNumber VARCHAR(15) NOT NULL
   ,Address VARCHAR(50)
   ,CONSTRAINT PK_Id_Owners
    PRIMARY KEY (Id)
)

CREATE TABLE AnimalTypes
(
	Id INT NOT NULL IDENTITY
   ,AnimalType VARCHAR(30) NOT NULL
   ,CONSTRAINT PK_Id_AnimalTypes
    PRIMARY KEY (Id)
)

CREATE TABLE Cages
(
	Id INT NOT NULL IDENTITY
   ,AnimalTypeId INT NOT NULL
   ,CONSTRAINT PK_Id_Cages
    PRIMARY KEY (Id)
   ,CONSTRAINT FK_Cages_AnimalTypes
    FOREIGN KEY (AnimalTypeId)
	REFERENCES AnimalTypes(Id)
)

CREATE TABLE Animals
(
	Id INT NOT NULL IDENTITY
   ,Name VARCHAR(30) NOT NULL
   ,BirthDate Date NOT NULL
   ,OwnerId INT
   ,AnimalTypeId INT NOT NULL
   ,CONSTRAINT PK_Id_Animals
    PRIMARY KEY (Id)
   ,CONSTRAINT FK_Animals_Owners
    FOREIGN KEY (OwnerId)
	REFERENCES Owners(Id)
   ,CONSTRAINT FK_Animals_AnimalTypes
    FOREIGN KEY (AnimalTypeId)
	REFERENCES AnimalTypes(Id)
)

CREATE TABLE AnimalsCages
(
	CageId INT NOT NULL
   ,AnimalId INT NOT NULL
   ,CONSTRAINT PK_CageId_AnimalId_AnimalsCages
    PRIMARY KEY (CageId, AnimalId)
   ,CONSTRAINT FK_AnimalsCages_Cages
    FOREIGN KEY (CageId)
	REFERENCES Cages(Id)
   ,CONSTRAINT FK_AnimalsCages_Animals
    FOREIGN KEY (AnimalId)
	REFERENCES Animals(Id)
)

CREATE TABLE VolunteersDepartments
(
	Id INT NOT NULL IDENTITY
   ,DepartmentName VARCHAR(30) NOT NULL
   ,CONSTRAINT PK_Id_VolunteersDepartments
    PRIMARY KEY (Id)
)

CREATE TABLE Volunteers
(
	Id INT NOT NULL IDENTITY
   ,Name VARCHAR(50) NOT NULL
   ,PhoneNumber VARCHAR(15) NOT NULL
   ,Address VARCHAR(50)
   ,AnimalId INT
   ,DepartmentId INT NOT NULL
   ,CONSTRAINT PK_Id_Volunteers
    PRIMARY KEY (Id)
   ,CONSTRAINT FK_Volunteers_Animals
    FOREIGN KEY (AnimalId)
	REFERENCES Animals(Id)
   ,CONSTRAINT FK_Volunteers_VolunteersDepartments
    FOREIGN KEY (DepartmentId)
	REFERENCES VolunteersDepartments(Id)
)