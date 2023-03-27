namespace ProductShop.DTOs.Export
{
    public class SoldProducts
    {
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string BuyerFirstName { get; set; } = null!;

        public string BuyerLastName { get; set;} = null!;
    }
}
