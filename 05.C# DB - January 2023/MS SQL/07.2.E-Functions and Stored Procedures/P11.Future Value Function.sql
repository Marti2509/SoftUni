CREATE FUNCTION ufn_CalculateFutureValue(@I DECIMAL, @R FLOAT, @T INT)
RETURNS DECIMAL(18, 4) AS
BEGIN
	DECLARE @result DECIMAL(18, 4)

	SET @result = @I * (POWER((1 + @R), @T))

	RETURN @result
END;

SELECT dbo.ufn_CalculateFutureValue(123.12, 0.1, 5) AS Result