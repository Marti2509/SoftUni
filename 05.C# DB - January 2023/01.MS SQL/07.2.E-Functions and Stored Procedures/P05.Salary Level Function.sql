USE SoftUni
GO

CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18, 4))
RETURNS VARCHAR(10) AS
BEGIN
	DECLARE @SalaryLevel VARCHAR(10)

	IF (@salary < 30000)
	BEGIN
		SET @SalaryLevel = 'Low'
	END
	ELSE IF (@salary <= 50000)
	BEGIN
		SET @SalaryLevel = 'Average'
	END
	ELSE
	BEGIN
		SET @SalaryLevel = 'High'
	END

	RETURN @SalaryLevel
END

SELECT Salary
	  ,dbo.ufn_GetSalaryLevel(Salary) AS SalaryLevel
  FROM Employees