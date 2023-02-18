USE Geography
GO

SELECT CountryName AS [Country Name]
	  ,IsoCode AS [ISO Code]
  FROM Countries
 WHERE LEN(LOWER(CountryName)) - LEN(LOWER(REPLACE(CountryName, 'a', ''))) >= 3
 ORDER BY IsoCode