USE SoftUni
GO

CREATE PROC usp_GetTownsStartingWith
		@string VARCHAR(10)
AS
	SELECT [Name] AS [Town]
	  FROM Towns
	 WHERE LEFT([Name], LEN(@string)) = @string

EXEC dbo.usp_GetTownsStartingWith 'b'