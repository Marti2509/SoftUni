using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Creator")]
    public class ImportCreatorsDTO
    {
        [Required]
        [MinLength(2)]
        [MaxLength(7)]
        [XmlElement("FirstName")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(7)]
        [XmlElement("LastName")]
        public string LastName { get; set; } = null!;

        [XmlArray()]
        public List<ImportBoardgamesDTO> Boardgames { get; set; } = null!;
    }
}
