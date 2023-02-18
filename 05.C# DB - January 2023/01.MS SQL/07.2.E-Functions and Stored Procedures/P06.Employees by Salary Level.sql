USE SoftUni
GO

CREATE PROC usp_EmployeesBySalaryLevel
		@salaryLevel VARCHAR(10)
AS
	SELECT FirstName
		  ,LastName
	  FROM Employees
	 WHERE LOWER(dbo.ufn_GetSalaryLevel(Salary)) = LOWER(@salaryLevel)

EXEC dbo.usp_EmployeesBySalaryLevel 'HiGh'