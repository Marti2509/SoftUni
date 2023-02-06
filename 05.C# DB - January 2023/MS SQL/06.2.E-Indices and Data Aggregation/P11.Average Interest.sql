USE Gringotts

SELECT DepositGroup
	  ,IsDepositExpired
	  ,AVG(DepositInterest) AS AverageInterest
  FROM WizzardDeposits
  WHERE DepositStartDate > '1985-1-1'
 GROUP BY DepositGroup
		 ,IsDepositExpired
 ORDER BY DepositGroup DESC
		 ,IsDepositExpired