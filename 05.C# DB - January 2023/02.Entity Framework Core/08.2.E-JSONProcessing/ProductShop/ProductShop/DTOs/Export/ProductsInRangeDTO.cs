namespace ProductShop.DTOs.Export
{
    public class ProductsInRangeDTO
    {
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Seller { get; set; } = null!;
    }
}
