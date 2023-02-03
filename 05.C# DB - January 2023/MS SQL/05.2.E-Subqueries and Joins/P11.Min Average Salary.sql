USE SoftUni
GO

SELECT MIN(avg) AS MinAverageSalary
  FROM 
  (
	SELECT AVG(Salary) AS [avg]
	  FROM Employees
	 GROUP BY DepartmentID
  ) AS [Table]