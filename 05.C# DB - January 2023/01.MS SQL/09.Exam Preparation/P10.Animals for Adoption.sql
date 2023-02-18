USE Zoo
GO

SELECT a.Name
	  ,YEAR(a.BirthDate) AS BirthYear
	  ,at.AnimalType
  FROM Animals AS a
  JOIN AnimalTypes AS at ON a.AnimalTypeId = at.Id
 WHERE a.OwnerId IS NULL
   AND DATEDIFF(year, a.BirthDate, '01-01-2022') < 5
   AND at.AnimalType <> 'Birds'
 ORDER BY a.Name