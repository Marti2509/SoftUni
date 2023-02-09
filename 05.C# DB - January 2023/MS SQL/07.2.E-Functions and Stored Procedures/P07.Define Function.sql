USE SoftUni
GO

CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(100), @word VARCHAR(70))
RETURNS BIT AS
BEGIN
	DECLARE @index int = 1
	
	WHILE(@index <= LEN(@word))
	BEGIN
		DECLARE @currLetter VARCHAR(1) = SUBSTRING(@word, @index, 1)

		IF (CHARINDEX(@currLetter, @setOfLetters) = 0)
		BEGIN
			RETURN 0;
		END

		SET @index = @index + 1
	END

	RETURN 1;
END

SELECT FirstName
	  ,dbo.ufn_IsWordComprised('dagkeundy', FirstName) AS Bool
  FROM Employees