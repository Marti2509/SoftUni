USE Diablo
GO

SELECT Username
	  ,STUFF(Email, 1, CHARINDEX('@', Email), '') AS [Email Provider]
  FROM Users
 ORDER BY [Email Provider]
		 ,Username