USE Zoo
GO

SELECT TOP 5
	   o.Name
	  ,COUNT(*) AS Count
  FROM Owners AS o
  JOIN Animals AS a ON o.Id = a.OwnerId
 GROUP BY o.Name
 ORDER BY Count DESC
		 ,o.Name