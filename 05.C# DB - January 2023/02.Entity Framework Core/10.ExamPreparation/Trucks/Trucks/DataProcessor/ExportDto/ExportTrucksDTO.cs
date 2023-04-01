using System.Xml.Serialization;

namespace Trucks.DataProcessor.ExportDto
{
    [XmlType("Truck")]
    public class ExportTrucksDTO
    {
        [XmlElement("RegistrationNumber")]
        public string? RegistrationNumber { get; set; }

        [XmlElement("Make")]
        public string Make { get; set; } = null!;
    }
}
