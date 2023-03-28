namespace CarDealer.DTOs.Export
{
    public class SalesDiscountDTO
    {
        public SalesCarDTO car { get; set; }

        public string customerName { get; set; } = null!;

        public string discount { get; set; } = null!;
         
        public string price { get; set; } = null!;

        public string priceWithDiscount { get; set; } = null!;
    }

    public class SalesCarDTO
    {
        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public long TraveledDistance { get; set; }
    }
}
