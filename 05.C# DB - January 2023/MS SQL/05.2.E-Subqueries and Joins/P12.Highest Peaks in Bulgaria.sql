USE Geography
GO

SELECT mc.CountryCode
	  ,m.MountainRange
	  ,p.PeakName
	  ,p.Elevation
  FROM Mountains AS m
  JOIN MountainsCountries AS mc ON m.Id = mc.MountainId
  JOIN Peaks AS p ON p.MountainId = mc.MountainId
 WHERE mc.CountryCode = 'BG'
   AND p.Elevation > 2835
 ORDER BY p.Elevation DESC