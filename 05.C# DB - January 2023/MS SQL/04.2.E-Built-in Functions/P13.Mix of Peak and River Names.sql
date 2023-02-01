USE Geography
GO

SELECT p.PeakName
	  ,r.RiverName
	  ,CONCAT(LOWER(STUFF(p.PeakName, LEN(p.PeakName), 1, '')), LOWER(r.RiverName)) AS Mix
  FROM Peaks AS p
  JOIN Rivers AS r ON RIGHT(LOWER(p.PeakName), 1) = LEFT(LOWER(r.RiverName), 1)
 ORDER BY Mix