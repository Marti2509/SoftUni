USE Boardgames
GO

SELECT c.Id
	  ,CONCAT(c.FirstName, ' ', c.LastName) AS CreatorName
	  ,Email
  FROM Creators AS c
  LEFT JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
 WHERE cb.BoardgameId IS NULL