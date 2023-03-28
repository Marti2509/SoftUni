using CarDealer.Models;

namespace CarDealer.DTOs.Export
{
    public class LocalSuppliesDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int PartsCount { get; set; }
    }
}
