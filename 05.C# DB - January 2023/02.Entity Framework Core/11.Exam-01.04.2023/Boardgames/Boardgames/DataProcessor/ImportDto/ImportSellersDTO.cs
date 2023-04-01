using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Boardgames.DataProcessor.ImportDto
{
    public class ImportSellersDTO
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        [JsonProperty("Name")]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [JsonProperty("Address")]
        public string Address { get; set; } = null!;

        [Required]
        [JsonProperty("Country")]
        public string Country { get; set; } = null!;

        [Required]
        [RegularExpression(@"www\.[a-zA-Z0-9-]+\.com")]
        [JsonProperty("Website")]
        public string Website { get; set; } = null!;

        [JsonProperty("Boardgames")]
        public List<int> BoardgameIds { get; set; } = null!;
    }
}
