using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto
{
    [XmlType("Creator")]
    public class ExportCreatorsDTO
    {
        [XmlAttribute("BoardgamesCount")]
        public int BoardgamesCount { get; set; }

        [XmlElement("CreatorName")]
        public string Name { get; set; } = null!;

        [XmlArray()]
        public List<ExportBoardgamesXmlDTO> Boardgames { get; set; } = null!;
    }
}
