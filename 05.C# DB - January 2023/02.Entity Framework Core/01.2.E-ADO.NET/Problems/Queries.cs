using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Problems
{
    internal class Queries
    {
        public const string villainNamesSQL = @"SELECT v.Name" +
            "                        ,COUNT(mv.VillainId) AS MinionsCount" +
            "                    FROM Villains AS v" +
            "                    JOIN MinionsVillains AS mv ON v.Id = mv.VillainId" +
            "                   GROUP BY v.Id" +
            "                           ,v.Name" +
            "                  HAVING COUNT(mv.VillainId) > 3" +
            "                   ORDER BY COUNT(mv.VillainId)";

        public const string minionNamesSQL1 = @"SELECT Name FROM Villains WHERE Id = @Id";

        public const string minionNamesSQL2 = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                                                       m.Name, 
                                                       m.Age
                                                  FROM MinionsVillains AS mv
                                                  JOIN Minions As m ON mv.MinionId = m.Id
                                                 WHERE mv.VillainId = @Id
                                                 ORDER BY m.Name";

        public const string addMinion1 = @"SELECT Id FROM Towns WHERE Name = @townName";

        public const string addMinion2 = @"SELECT Id FROM Villains WHERE Name = @Name";

        public const string addMinion3 = @"SELECT Id FROM Minions WHERE Name = @Name";
                            
        public const string addMinion4 = @"INSERT INTO Towns (Name) VALUES (@townName)";
                            
        public const string addMinion5 = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";
                            
        public const string addMinion6 = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";
                            
        public const string addMinion7 = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";

        public const string changeTownNamesCasing1 = @"SELECT t.Name 
                                                        FROM Towns as t
                                                        JOIN Countries AS c ON c.Id = t.CountryCode
                                                       WHERE c.Name = @countryName";

        public const string changeTownNamesCasing2 = @"UPDATE Towns
                                                          SET Name = UPPER(Name)
                                                        WHERE CountryCode = (SELECT c.Id 
                                                                               FROM Countries AS c 
                                                                              WHERE c.Name = @countryName)";

        public const string removeVillain1 = @"SELECT Name FROM Villains WHERE Id = @villainId";

        public const string removeVillain2 = @"DELETE FROM MinionsVillains WHERE VillainId = @villainId";

        public const string removeVillain3 = @"DELETE FROM Villains WHERE Id = @villainId";

        public const string printAllMinionNames = @"SELECT Name FROM Minions";

        public const string increaseMinionAge1 = @"SELECT Name, Age FROM Minions";

        public const string increaseMinionAge2 = @" UPDATE Minions
                                                      SET Name = LOWER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name))
                                                         ,Age += 1
                                                    WHERE Id = @Id";

        public const string increaseAgeStoredProcedure1 = @"EXEC [dbo].[usp_GetOlder] @MinionId";

        public const string increaseAgeStoredProcedure2 = @"SELECT Name, Age FROM Minions WHERE Id = @Id";
    }
}
