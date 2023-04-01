namespace Trucks.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;
    using System.Text;
    using Data;
    using Newtonsoft.Json;
    using Trucks.Data.Models;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ImportDto;
    using Trucks.Utils;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        public static string ImportDespatcher(TrucksContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XMLHelper helper = new XMLHelper();

            var deserialized = helper.Deserialize<ImportDespatchersDTO[]>(xmlString, "Despatchers");

            var despatchers = new List<Despatcher>();

            foreach (var despatcher in deserialized)
            {
                if (!IsValid(despatcher))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Despatcher currDespatcher = new Despatcher
                {
                    Name = despatcher.Name,
                    Position = despatcher.Position,
                };

                foreach (var truck in despatcher.Trucks)
                {
                    if (!IsValid(truck))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Truck currTruck = new Truck
                    {
                        RegistrationNumber = truck.RegistrationNumber,
                        VinNumber = truck.VinNumber,
                        TankCapacity = truck.TankCapacity,
                        CargoCapacity = truck.CargoCapacity,
                        CategoryType = (CategoryType)truck.CategoryType,
                        MakeType = (MakeType)truck.MakeType
                    };

                    currDespatcher.Trucks.Add(currTruck);
                }

                despatchers.Add(currDespatcher);
                sb.AppendLine(String.Format(SuccessfullyImportedDespatcher, currDespatcher.Name, currDespatcher.Trucks.Count));
            }

            context.Despatchers.AddRange(despatchers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }
        public static string ImportClient(TrucksContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            List<ImportClientsDTO> deserialized = JsonConvert.DeserializeObject<List<ImportClientsDTO>>(jsonString);

            var clients = new List<Client>();

            var trucks = context.Trucks
                .Select(t => t.Id)
                .ToList();

            foreach (var client in deserialized)
            {
                if (!IsValid(client))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (client.Type == "usual")
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Client currClient = new Client
                {
                    Name = client.Name,
                    Nationality = client.Nationality,
                    Type = client.Type
                };

                foreach (var truckId in client.TruckIds.Distinct())
                {
                    if (!trucks.Contains(truckId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Truck findTruck = context.Trucks
                        .Find(truckId);

                    currClient.ClientsTrucks.Add(new ClientTruck { Client = currClient, Truck = findTruck });
                }

                clients.Add(currClient);
                sb.AppendLine(String.Format(SuccessfullyImportedClient, currClient.Name, currClient.ClientsTrucks.Count));
            }

            context.Clients.AddRange(clients);
            context.SaveChangesAsync();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}