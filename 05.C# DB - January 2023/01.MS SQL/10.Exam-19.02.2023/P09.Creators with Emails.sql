USE Boardgames
GO

SELECT CONCAT(c.FirstName, ' ', c.LastName) AS FullName
	  ,c.Email
	  ,MAX(b.Rating) AS Rating
  FROM Creators AS c
  JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
  JOIN Boardgames AS b ON cb.BoardgameId = b.Id
 WHERE c.Email LIKE '%.com'
 GROUP BY c.FirstName, c.LastName, c.Email