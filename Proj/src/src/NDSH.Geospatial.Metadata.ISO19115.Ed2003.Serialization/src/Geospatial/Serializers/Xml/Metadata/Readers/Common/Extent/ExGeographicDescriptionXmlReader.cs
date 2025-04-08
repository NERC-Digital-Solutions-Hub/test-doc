using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Extent {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="EX_GeographicDescription_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class ExGeographicDescriptionXmlReader : XmlElementReader<EX_GeographicDescription_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="EX_GeographicDescription_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="EX_GeographicDescription_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="EX_GeographicDescription_Type"/> instance that represents the XML element.</returns>
    public override EX_GeographicDescription_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new EX_GeographicDescription_Type { GeographicIdentifier = this.Get<MD_Identifier_Type>("geographicIdentifier", element, options) };
    }
  }
}
