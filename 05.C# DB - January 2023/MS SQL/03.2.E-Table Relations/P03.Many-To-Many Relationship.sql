USE master
GO

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
	StudentID INT NOT NULL,
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