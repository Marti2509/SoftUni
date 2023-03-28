namespace CarDealer.DTOs.Export
{
    public class CarWithPartsDTO
    {
        public CarsDTO car { get; set; }

        public List<PartsDTO> parts { get; set; }
    }

    public class CarsDTO
    {
        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public long TraveledDistance { get; set; }
    }

    public class PartsDTO
    {
        public string Name { get; set; } = null!;

        public string Price { get; set; } = null!;
    }
}
