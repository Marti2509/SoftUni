namespace Boardgames.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ImportDto;
    using Boardgames.Utils;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";

        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XMLHelper helper = new XMLHelper();

            var deserialized = helper.Deserialize<List<ImportCreatorsDTO>>(xmlString, "Creators");

            var creators = new List<Creator>();

            foreach (var creator in deserialized)
            {
                if (!IsValid(creator))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Creator currCreator = new Creator
                {
                    FirstName = creator.FirstName,
                    LastName = creator.LastName
                };

                foreach (var boardgame in creator.Boardgames)
                {
                    if (!IsValid(boardgame))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Boardgame currBoardgame = new Boardgame
                    {
                        Name = boardgame.Name,
                        Rating = boardgame.Rating,
                        YearPublished = boardgame.YearPublished,
                        CategoryType = (CategoryType)boardgame.CategoryType,
                        Mechanics = boardgame.Mechanics
                    };

                    currCreator.Boardgames.Add(currBoardgame);
                }

                creators.Add(currCreator);
                sb.AppendLine(String.Format(SuccessfullyImportedCreator, currCreator.FirstName, currCreator.LastName, currCreator.Boardgames.Count));
            }

            context.Creators.AddRange(creators);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var deserialized = JsonConvert.DeserializeObject<List<ImportSellersDTO>>(jsonString);

            var boardgameIds = context.Boardgames
                .Select(b => b.Id)
                .ToList();

            var sellers = new List<Seller>();

            foreach (var seller in deserialized)
            {
                if (!IsValid(seller))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Seller currSeller = new Seller
                {
                    Name = seller.Name,
                    Address = seller.Address,
                    Country = seller.Country,
                    Website = seller.Website
                };

                foreach (var boardgameId in seller.BoardgameIds.Distinct())
                {
                    if (!boardgameIds.Contains(boardgameId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Boardgame findBoardgame = context.Boardgames
                        .Find(boardgameId);

                    currSeller.BoardgamesSellers.Add(new BoardgameSeller { Seller = currSeller, Boardgame = findBoardgame });
                }

                sellers.Add(currSeller);
                sb.AppendLine(String.Format(SuccessfullyImportedSeller, currSeller.Name, currSeller.BoardgamesSellers.Count));
            }

            context.Sellers.AddRange(sellers);
            context.SaveChanges();

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
