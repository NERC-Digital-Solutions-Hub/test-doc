using NDSH.Geospatial.Metadata.Extent;
using System.Xml;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Extent {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="AbstractEX_GeographicExtent_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class AbstractExGeographicExtentXmlReader : XmlElementReader<AbstractEX_GeographicExtent_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="AbstractEX_GeographicExtent_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="AbstractEX_GeographicExtent_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="AbstractEX_GeographicExtent_Type"/> instance that represents the XML element.</returns>
    public override AbstractEX_GeographicExtent_Type Read(XElement element, XmlElementSerializerOptions options) {
      return element.Name.LocalName switch {
        "EX_GeographicBoundingBox" => XmlElementSerializer.Read<EX_GeographicBoundingBox_Type>(element, options),
        "EX_GeographicDescription" => XmlElementSerializer.Read<EX_GeographicDescription_Type>(element, options),
        _ => throw new XmlException($"Unknown element '{element.Name.LocalName}'.")
      };
    }
  }
}
