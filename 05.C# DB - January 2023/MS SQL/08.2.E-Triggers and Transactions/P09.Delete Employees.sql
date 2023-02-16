USE SoftUni
GO

CREATE TABLE Deleted_Employees
(
	EmployeeId INT IDENTITY
   ,FirstName NVARCHAR(50)
   ,LastName NVARCHAR(50)
   ,MiddleName NVARCHAR(50)
   ,JobTitle NVARCHAR(50)
   ,DepartmentId INT
   ,Salary DECIMAL(15, 2)
   ,CONSTRAINT PK_Deleted_Employees 
	PRIMARY KEY(EmployeeId)
   ,CONSTRAINT FK_Deleted_Employees_Departments 
	FOREIGN KEY(DepartmentId) 
	REFERENCES Departments(DepartmentId)
)

CREATE TRIGGER tr_AddToDeleted_Employees_Table
ON Employees FOR DELETE
AS
	INSERT INTO Deleted_Employees(FirstName
								 ,LastName
								 ,MiddleName
								 ,JobTitle
								 ,DepartmentId
								 ,Salary)
	SELECT d.FirstName
		  ,d.LastName
		  ,d.MiddleName
		  ,d.JobTitle
		  ,d.DepartmentID
		  ,d.Salary
	FROM deleted AS d
GO

INSERT INTO Employees(FirstName
					 ,LastName 
					 ,MiddleName
					 ,JobTitle
					 ,DepartmentId
					 ,Salary
					 ,HireDate)
VALUES
('Marto', 'Simov', 'Dimitrov', 'C# Developer', 7, 15000, GETDATE());

DELETE
  FROM Employees
 WHERE EmployeeID = 296

SELECT *
  FROM Deleted_Employees