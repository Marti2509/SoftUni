USE SoftUni
GO

--	Problem 2
SELECT * 
  FROM Departments

--	Problem 3
SELECT [Name] 
  FROM Departments

--	Problem 4
SELECT [FirstName]
	  ,[LastName]
	  ,[Salary]
  FROM Employees

--	Problem 5
SELECT [FirstName]
	  ,[MiddleName]
	  ,[LastName]
  FROM Employees

--	Problem 6
SELECT CONCAT([FirstName], '.', LastName, '@', 'softuni.bg')
	AS [Full Email Address]
  FROM Employees

--	Problem 7
SELECT DISTINCT Salary
  FROM Employees

--	Problem 8
SELECT *
  FROM Employees
 WHERE JobTitle = 'Sales Representative';

--	Problem 9
SELECT [FirstName]
	  ,[LastName]
	  ,[JobTitle]
  FROM Employees
 WHERE Salary BETWEEN 20000 AND 30000

--	PROBLEM 10
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName])
    AS [Full Name]
  FROM Employees
 WHERE Salary IN (25000, 14000, 12500, 23600)

--	PROBLEM 11
SELECT FirstName
	  ,LastName
  FROM Employees
 WHERE ManagerID IS NULL

--	PROBLEM 12
SELECT FirstName
	  ,LastName
	  ,Salary
  FROM Employees
 WHERE Salary >= 50000
 ORDER BY Salary DESC

--	PROBLEM 13
SELECT TOP(5) FirstName
			 ,LastName
  FROM Employees
 ORDER BY Salary DESC

--	PROBLEM 14
SELECT FirstName
      ,LastName
  FROM Employees
 WHERE DepartmentID <> 4

--	PROBLEM 15
SELECT *
  FROM Employees
 ORDER BY Salary DESC
		 ,FirstName
		 ,LastName DESC
		 ,MiddleName

--	PROBLEM 16
CREATE VIEW V_EmployeesSalaries AS
SELECT FirstName
	  ,LastName
	  ,Salary
  FROM Employees
GO

SELECT * FROM V_EmployeesSalaries

--	PROBLEM 17
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS [Full Name]
	  ,JobTitle AS [Job Title]
  FROM Employees
GO

SELECT * FROM V_EmployeeNameJobTitle

--	PROBLEM 18
SELECT DISTINCT JobTitle
  FROM Employees

--	PROBLEM 19
SELECT TOP(10) *
  FROM Projects
 WHERE StartDate IS NOT NULL
 ORDER BY StartDate
		 ,[Name]

--	PROBLEM 20
SELECT TOP(7) FirstName
			 ,LastName
			 ,HireDate
  FROM Employees
 ORDER BY HireDate DESC

--	PROBLEM 21
UPDATE Employees
   SET Salary = Salary + Salary * 0.12
 WHERE DepartmentID IN (1, 2, 4, 11)

SELECT Salary
  FROM Employees

USE Geography
GO

--	PROBLEM 22
SELECT PeakName 
  FROM Peaks
 ORDER BY PeakName

--	PROBLEM 23
SELECT TOP(30) CountryName
			  ,[Population]
  FROM Countries
 WHERE ContinentCode = 'EU'
 ORDER BY [Population] DESC
					  ,CountryName

--	PROBLEM 24
SELECT CountryName
	  ,CountryCode
	  ,(CASE 
			WHEN CurrencyCode = 'EUR' THEN 'Euro'
			ELSE 'Not Euro'
		 END) AS Currency
  FROM Countries
 ORDER BY CountryName

USE Diablo
GO

--	PROBLEM 25
SELECT [Name]
  FROM Characters
 ORDER BY [Name]