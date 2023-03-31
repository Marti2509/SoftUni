using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    [XmlType("Users")]
    public class ExportUsersCountDTO
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("users")]
        public List<ExportUsersDTO> Users { get; set; } = new List<ExportUsersDTO>();
    }

    [XmlType("User")]
    public class ExportUsersDTO
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; } = null!;

        [XmlElement("lastName")]
        public string LastName { get; set; } = null!;

        [XmlElement("age")]
        public int? Age { get; set; }

        public List<ExportSoldProducts2> SoldProducts { get; set; } = new List<ExportSoldProducts2>();
    }

    [XmlType("SoldProducts")]
    public class ExportSoldProducts2
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("products")]
        public List<ExportProducts> Products { get; set; } = new List<ExportProducts>();
    }

    [XmlType("Product")]
    public class ExportProducts
    {
        [XmlElement("name")]
        public string Name { get; set; } = null!;

        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}
