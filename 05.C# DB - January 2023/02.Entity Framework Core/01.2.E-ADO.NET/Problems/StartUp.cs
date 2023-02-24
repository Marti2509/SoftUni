using Microsoft.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Text;
using static Azure.Core.HttpHeader;

namespace Problems
{
    public class StartUp
    {
        static async Task Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection(Config.sqlConnectionData);
            await connection.OpenAsync();

            string result = await PrintAllMinionNames(connection);
            Console.WriteLine(result);
        }

        // PROBLEM 2
        static async Task<string> VillainNames(SqlConnection connection)
        {
            StringBuilder sb = new StringBuilder();

            SqlCommand command = new SqlCommand(Queries.villainNamesSQL, connection);

            SqlDataReader reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                string name = (string)reader["Name"];
                int count = (int)reader["MinionsCount"];

                sb.Append(name + " - " + count);
            }

            return sb.ToString().TrimEnd();
        }

        // PROBLEM 3
        static async Task<string> MinionNames(SqlConnection connection)
        {
            int id = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            SqlCommand commandName = new SqlCommand(Queries.minionNamesSQL1, connection);
            commandName.Parameters.AddWithValue("@Id", id);

            object? villian = await commandName.ExecuteScalarAsync();

            if (villian == null)
            {
                return $"No villain with ID {id} exists in the database.";
            }

            sb.AppendLine($"Villain: {villian}");

            SqlCommand commandMinions = new SqlCommand(Queries.minionNamesSQL2, connection);
            commandMinions.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = await commandMinions.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                long rowNumber = (long)reader["RowNum"];
                string minionName = (string)reader["Name"];
                int minionAge = (int)reader["Age"];

                sb.AppendLine($"{rowNumber}. {minionName} {minionAge}");
            }

            return sb.ToString().TrimEnd();
        }

        //PROBLEM 4
        static async Task<string> AddMinion(SqlConnection connection)
        {
            StringBuilder sb = new StringBuilder();

            //"Minion: <Name> <Age> <TownName>"

            string[] minionInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string minionName = minionInput[1];
            int minionAge = int.Parse(minionInput[2]);
            string minionTown = minionInput[3];

            //"Villain: <Name>"

            string[] villainInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string villainName = villainInput[1];

            SqlCommand townCommand = new SqlCommand(Queries.addMinion1, connection);
            townCommand.Parameters.AddWithValue("@townName", minionTown);

            object? minionTownId = await townCommand.ExecuteScalarAsync();

            if (minionTownId == null)
            {
                SqlCommand addTownCommand = new SqlCommand(Queries.addMinion4, connection);
                addTownCommand.Parameters.AddWithValue("@townName", minionTown);

                await addTownCommand.ExecuteNonQueryAsync();

                sb.AppendLine($"Town {minionTown} was added to the database.");

                minionTownId = await townCommand.ExecuteScalarAsync();
            }

            SqlCommand villainCommand = new SqlCommand(Queries.addMinion2, connection);
            villainCommand.Parameters.AddWithValue("@Name", villainName);

            object? villainId = await villainCommand.ExecuteScalarAsync();

            if (villainId == null)
            {
                SqlCommand addVillainCommand = new SqlCommand(Queries.addMinion5, connection);
                addVillainCommand.Parameters.AddWithValue("villainName", villainName);

                await addVillainCommand.ExecuteNonQueryAsync();

                sb.AppendLine($"Villain {villainName} was added to the database.");

                villainId = await villainCommand.ExecuteScalarAsync();
            }

            SqlCommand minionCommand = new SqlCommand(Queries.addMinion3, connection);
            minionCommand.Parameters.AddWithValue("@Name", minionName);

            object? minionId = await villainCommand.ExecuteScalarAsync();

            if (minionId == null)
            {
                SqlCommand addMinionCommand = new SqlCommand(Queries.addMinion6, connection);
                addMinionCommand.Parameters.AddWithValue("@name", minionName);
                addMinionCommand.Parameters.AddWithValue("@age", minionAge);
                addMinionCommand.Parameters.AddWithValue("@town", minionTownId);

                await addMinionCommand.ExecuteNonQueryAsync();

                minionId = await villainCommand.ExecuteScalarAsync();
            }

            SqlCommand addToMinionsVillains = new SqlCommand(Queries.addMinion7, connection);
            addToMinionsVillains.Parameters.AddWithValue("minionId", minionId);
            addToMinionsVillains.Parameters.AddWithValue("villainId", villainId);

            await addToMinionsVillains.ExecuteNonQueryAsync();

            sb.AppendLine($"Successfully added {minionName} to be minion of {villainName}.");

            return sb.ToString().TrimEnd();
        }

        // PROBLEM 5
        static async Task<string> ChangeTownNamesCasing(SqlConnection connection)
        {
            string? countryName = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            SqlCommand townsCommand = new SqlCommand(Queries.changeTownNamesCasing1, connection);
            townsCommand.Parameters.AddWithValue("@countryName", countryName);

            object? town = await townsCommand.ExecuteScalarAsync();

            if (town == null)
            {
                return "No town names were affected.";
            }

            SqlCommand updateTowns = new SqlCommand(Queries.changeTownNamesCasing2, connection);
            updateTowns.Parameters.AddWithValue("@countryName", countryName);

            int count = await updateTowns.ExecuteNonQueryAsync();

            sb.AppendLine($"{count} town names were affected.");

            SqlDataReader reader = await townsCommand.ExecuteReaderAsync();

            List<string> towns = new List<string>();

            while (await reader.ReadAsync())
            {
                towns.Add((string)reader["Name"]);
            }

            sb.AppendLine($"[{string.Join(", ", towns)}]");

            return sb.ToString().TrimEnd();
        }

        // PROBLEM 6
        static async Task<string> RemoveVillain(SqlConnection connection)
        {
            int villainId = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            SqlCommand villainCommand = new SqlCommand(Queries.removeVillain1, connection);
            villainCommand.Parameters.AddWithValue("@villainId", villainId);

            object? villainName = await villainCommand.ExecuteScalarAsync();

            if (villainName == null)
            {
                return "No such villain was found.";
            }

            SqlCommand minionsCommand = new SqlCommand(Queries.removeVillain2, connection);
            minionsCommand.Parameters.AddWithValue("@villainId", villainId);

            int freeMinionsCount = await minionsCommand.ExecuteNonQueryAsync();

            SqlCommand removeVillainCommand = new SqlCommand(Queries.removeVillain3, connection);
            removeVillainCommand.Parameters.AddWithValue("@villainId", villainId);

            await removeVillainCommand.ExecuteNonQueryAsync();

            sb.AppendLine($"{villainName} was deleted.");
            sb.AppendLine($"{freeMinionsCount} minions were released.");

            return sb.ToString().TrimEnd();
        }

        // PROBLEM 7
        static async Task<string> PrintAllMinionNames(SqlConnection connection)
        {
            List<string> minions = new List<string>();
            StringBuilder sb = new StringBuilder();

            SqlCommand getAllMinionsCommand = new SqlCommand(Queries.printAllMinionNames, connection);

            SqlDataReader reader = await getAllMinionsCommand.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                minions.Add((string)reader["Name"]);
            }

            for (int i = 0; i < minions.Count / 2; i++)
            {
                sb.AppendLine(minions[i]);
                sb.AppendLine(minions[minions.Count - 1 - i]);
            }

            if (minions.Count % 2 == 1)
            {
                sb.AppendLine(minions[minions.Count / 2]);
            }

            return sb.ToString().TrimEnd();
        }
    }
}