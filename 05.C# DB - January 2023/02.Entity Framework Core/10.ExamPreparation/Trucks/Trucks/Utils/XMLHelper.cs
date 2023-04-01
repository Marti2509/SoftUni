using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trucks.Utils
{
    public class XMLHelper
    {
        public T Deserialize<T>(string xmlString, string rootElement)
        {
            var serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(rootElement));

            using (StringReader reader = new StringReader(xmlString))
            {
                T? deserialized = (T?)serializer.Deserialize(reader);

                return deserialized;
            }
        }

        public string Serialize<T>(T obj, string rootElement)
        {
            StringBuilder sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(rootElement));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using (StringWriter writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, obj, namespaces);

                return sb.ToString().TrimEnd();
            }
        }
    }
}