USE Diablo
GO

SELECT [Name]
	  ,'Part of the Day' = CASE
		WHEN DATEPART(HOUR, [Start]) BETWEEN 0 AND 11 THEN 'Morning'
		WHEN DATEPART(HOUR, [Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
		WHEN DATEPART(HOUR, [Start]) BETWEEN 18 AND 24 THEN 'Evening'
		 END
	  ,Duration = CASE
	    WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration <= 6 THEN 'Short'
		WHEN Duration > 6 THEN 'Long'
		WHEN Duration IS NULL THEN 'Extra Long'
		 END
  FROM Games
 ORDER BY [Name]
		 ,Duration
		 ,[Part of the Day]