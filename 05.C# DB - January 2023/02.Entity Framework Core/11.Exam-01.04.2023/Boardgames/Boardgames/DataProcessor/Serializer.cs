namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.DataProcessor.ExportDto;
    using Boardgames.Utils;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
        {
            XMLHelper helper = new XMLHelper();

            var creators = context.Creators
                .Where(c => c.Boardgames.Count >= 1)
                .ToList()
                .Select(c => new ExportCreatorsDTO
                {
                    Name = $"{c.FirstName} {c.LastName}",
                    BoardgamesCount = c.Boardgames.Count,
                    Boardgames = c.Boardgames.Select(b => new ExportBoardgamesXmlDTO
                    {
                        Name = b.Name,
                        YearPublished = b.YearPublished,
                    })
                    .OrderBy(b => b.Name)
                    .ToList()
                })
                .OrderByDescending(c => c.BoardgamesCount)
                .ThenBy(c => c.Name)
                .ToList();

            return helper.Serialize<List<ExportCreatorsDTO>>(creators, "Creators");
        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var sellers = context.Sellers
                .Where(s => s.BoardgamesSellers
                        .Any(b => b.Boardgame.YearPublished >= year
                               && b.Boardgame.Rating <= rating))
                .ToList()
                .Select(s => new ExportSellersDTO
                {
                    Name = s.Name,
                    Website = s.Website,
                    Boardgames = s.BoardgamesSellers
                    .Where(b => b.Boardgame.YearPublished >= year
                             && b.Boardgame.Rating <= rating)
                    .Select(b => new ExportBoardgamesJsonDTO
                    {
                        Name = b.Boardgame.Name,
                        Rating = b.Boardgame.Rating,
                        Mechanics = b.Boardgame.Mechanics,
                        Category = b.Boardgame.CategoryType.ToString()
                    })
                    .OrderByDescending(b => b.Rating)
                    .ThenBy(b => b.Name)
                    .ToList()
                })
                .OrderByDescending(s => s.Boardgames.Count)
                .ThenBy(s => s.Name)
                .Take(5)
                .ToList();

            return JsonConvert.SerializeObject(sellers, Formatting.Indented);
        }
    }
}