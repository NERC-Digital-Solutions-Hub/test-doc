
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.Service.Metadata;
using System.Xml;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="AbstractMD_Identification_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class AbstractMdIdentificationXmlReader : XmlElementReader<AbstractMD_Identification_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="AbstractMD_Identification_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="AbstractMD_Identification_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="AbstractMD_Identification_Type"/> instance that represents the XML element.</returns>
    public override AbstractMD_Identification_Type Read(XElement element, XmlElementSerializerOptions options) {
      return element.Name.LocalName switch {
        "MD_DataIdentification" => XmlElementSerializer.Read<MD_DataIdentification_Type>(element, options),
        "SV_ServiceIdentification" => XmlElementSerializer.Read<SV_ServiceIdentification_Type>(element, options),
        _ => throw new XmlException($"Unknown element '{element.Name.LocalName}'.")
      };
    }
  }
}
