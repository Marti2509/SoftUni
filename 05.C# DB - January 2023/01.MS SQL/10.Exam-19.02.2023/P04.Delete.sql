USE Boardgames
GO

DELETE
  FROM CreatorsBoardgames
 WHERE BoardgameId IN (SELECT Id
						 FROM Boardgames
						WHERE PublisherId IN (SELECT p.Id
												FROM Publishers AS p
												JOIN Addresses AS a ON p.AddressId = a.Id
											   WHERE a.Country = (SELECT Country
																	FROM Addresses
																   WHERE Town LIKE 'L%')))

DELETE
  FROM Boardgames
 WHERE PublisherId IN (SELECT p.Id
						 FROM Publishers AS p
						 JOIN Addresses AS a ON p.AddressId = a.Id
						WHERE a.Country = (SELECT Country
											 FROM Addresses
											WHERE Town LIKE 'L%'))

DELETE
  FROM Publishers
 WHERE Id IN (SELECT p.Id
				FROM Publishers AS p
				JOIN Addresses AS a ON p.AddressId = a.Id
				WHERE a.Country = (SELECT Country
									 FROM Addresses
									WHERE Town LIKE 'L%'))

DELETE
  FROM Addresses
 WHERE Country = (SELECT Country
					FROM Addresses
					WHERE Town LIKE 'L%')