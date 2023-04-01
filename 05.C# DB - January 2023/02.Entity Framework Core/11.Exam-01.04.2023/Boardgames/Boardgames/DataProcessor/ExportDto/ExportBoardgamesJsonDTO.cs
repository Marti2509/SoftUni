﻿using Newtonsoft.Json;

namespace Boardgames.DataProcessor.ExportDto
{
    public class ExportBoardgamesJsonDTO
    {
        [JsonProperty("Name")]
        public string Name { get; set; } = null!;

        [JsonProperty("Rating")]
        public double Rating { get; set; }

        [JsonProperty("Mechanics")]
        public string Mechanics { get; set; } = null!;

        [JsonProperty("Category")]
        public string Category { get; set; } = null!;
    }
}
