namespace ProductShop.DTOs.Export
{
    public class CategoryProductsDTO
    {
        public string Category { get; set; } = null!;

        public int ProductsCount { get; set; }

        public string AveragePrice { get; set; } = null!;

        public string TotalRevenue { get; set; } = null!;
    }
}
