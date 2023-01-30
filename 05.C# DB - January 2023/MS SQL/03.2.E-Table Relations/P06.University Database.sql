USE master
GO

CREATE DATABASE University
GO

USE University
GO

CREATE TABLE Majors
(
	MajorID INT NOT NULL IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	CONSTRAINT PK_MajorID
	PRIMARY KEY (MajorID)
)

CREATE TABLE Students
(
	StudentID INT NOT NULL IDENTITY,
	StudentNumber INT NOT NULL,
	StudentName VARCHAR(50) NOT NULL,
	MajorID INT NOT NULL,
	CONSTRAINT PK_StudentID
	PRIMARY KEY (StudentID),
	CONSTRAINT FK_Students_Majors
	FOREIGN KEY (MajorID)
	REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
	PaymentID INT NOT NULL IDENTITY,
	PaymentDate DATE NOT NULL,
	PaymentAmount MONEY NOT NULL,
	StudentID INT NOT NULL,
	CONSTRAINT PK_PaymentID
	PRIMARY KEY (PaymentID),
	CONSTRAINT FK_Payments_Students
	FOREIGN KEY (StudentID)
	REFERENCES Students(StudentID)
)

CREATE TABLE Subjects
(
	SubjectID INT NOT NULL IDENTITY,
	SubjectName VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_SubjectID
	PRIMARY KEY (SubjectID)
)

CREATE TABLE Agenda
(
	StudentID INT NOT NULL,
	SubjectID INT NOT NULL,
	CONSTRAINT PK_StudentID_SubjectID
	PRIMARY KEY (StudentID, SubjectID),
	CONSTRAINT FK_Agenda_Students
	FOREIGN KEY (StudentID)
	REFERENCES Students(StudentID),
	CONSTRAINT FK_Agenda_Subjects
	FOREIGN KEY (SubjectID)
	REFERENCES Subjects(SubjectID)
)