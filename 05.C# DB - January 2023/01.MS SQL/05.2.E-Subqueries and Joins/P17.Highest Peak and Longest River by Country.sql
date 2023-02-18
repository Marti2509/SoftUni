USE Geography
GO

SELECT TOP 5
	   [Table].CountryName
	  ,MAX([Table].PeakElevation) AS HighestPeakElevation
	  ,MAX([Table].RiverLength) AS LongestRiverLength
  FROM
  (
	SELECT cy.CountryName AS CountryName
		  ,p.Elevation AS PeakElevation
		  ,r.[Length] AS RiverLength
	  FROM Countries AS cy
      LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = cy.CountryCode
	  LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId
	  LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = cy.CountryCode
	  LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
  ) AS [Table]
 GROUP BY [Table].CountryName
 ORDER BY MAX([Table].PeakElevation) DESC
		 ,MAX([Table].RiverLength) DESC
		 ,[Table].CountryName DESC