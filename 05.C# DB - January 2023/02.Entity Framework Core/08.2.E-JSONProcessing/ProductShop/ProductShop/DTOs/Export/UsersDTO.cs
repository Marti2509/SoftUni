namespace ProductShop.DTOs.Export
{
    public class UsersDTO
    {
        public UsersDTO()
        {
            SoldProducts = new List<CountProductsDTO>();
        }

        public string LastName { get; set; } = null!;

        public int? Age { get; set; }

        public ICollection<CountProductsDTO> SoldProducts { get; set; }
    }
}
