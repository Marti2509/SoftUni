namespace CarDealer.DTOs.Export
{
    public class CustomerCarsDTO
    {
        public string FullName { get; set; } = null!;

        public int BoughtCars { get; set; }

        public decimal SpentMoney { get; set; }
    }
}
