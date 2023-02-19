USE Boardgames
GO

CREATE FUNCTION udf_CreatorWithBoardgames(@name NVARCHAR(30))
RETURNS INT AS
BEGIN
	RETURN(SELECT COUNT(*)
			 FROM Creators AS c
			 JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
			WHERE c.FirstName = @name)
END

SELECT dbo.udf_CreatorWithBoardgames('Bruno')