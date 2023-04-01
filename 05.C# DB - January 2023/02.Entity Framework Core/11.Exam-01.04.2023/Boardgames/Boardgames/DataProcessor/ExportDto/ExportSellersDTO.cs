using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ExportDto
{
    public class ExportSellersDTO
    {
        [JsonProperty("Name")]
        public string Name { get; set; } = null!;

        [JsonProperty("Website")]
        public string Website { get; set; } = null!;

        [JsonProperty("Boardgames")]
        public List<ExportBoardgamesJsonDTO> Boardgames { get; set; } = null!;
    }
}
