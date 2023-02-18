USE Zoo
GO

SELECT CONCAT(o.Name, '-', a.Name) AS OwnersAnimals
	  ,o.PhoneNumber
	  ,ac.CageId
  FROM Animals AS a
  JOIN Owners AS o ON a.OwnerId = o.Id
  JOIN AnimalsCages AS ac ON a.Id = ac.AnimalId
  JOIN AnimalTypes AS at ON at.Id = a.AnimalTypeId
 WHERE at.AnimalType = 'mammals'
 ORDER BY o.Name
		 ,a.Name DESC