namespace ProductShop.DTOs.Export
{
    public class UserSoldProducts
    {
        public UserSoldProducts()
        {
            SoldProducts = new List<SoldProducts>();
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public ICollection<SoldProducts> SoldProducts { get; set; } = null!;
    }
}
