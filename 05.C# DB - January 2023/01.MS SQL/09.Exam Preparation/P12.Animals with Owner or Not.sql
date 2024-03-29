USE Zoo
GO

CREATE PROC usp_AnimalsWithOwnersOrNot
		@AnimalName VARCHAR(30)
AS
	SELECT a.Name
		  ,(CASE
				WHEN o.Name IS NULL THEN 'For adoption'
				ELSE o.Name
			 END) AS OwnersName
	  FROM Animals AS a
	  LEFT JOIN Owners AS o ON a.OwnerId = o.Id
	 WHERE a.Name = @AnimalName
GO

EXEC usp_AnimalsWithOwnersOrNot 'Pumpkinseed Sunfish'
EXEC usp_AnimalsWithOwnersOrNot 'Hippo'