namespace ProductShop.DTOs.Export
{
    public class CountProductsDTO
    {
        public CountProductsDTO()
        {
            Products = new List<ProductsDTO>();
        }

        public int Count { get; set; }

        public ICollection<ProductsDTO> Products { get; set; }
    }
}
