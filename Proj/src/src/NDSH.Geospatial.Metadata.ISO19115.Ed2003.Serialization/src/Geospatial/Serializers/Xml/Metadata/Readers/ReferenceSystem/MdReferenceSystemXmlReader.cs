
using NDSH.Geospatial.Metadata.ReferenceSystem;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ReferenceSystem {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_ReferenceSystem_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdReferenceSystemXmlReader : XmlElementReader<MD_ReferenceSystem_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_ReferenceSystem_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_ReferenceSystem_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_ReferenceSystem_Type"/> instance that represents the XML element.</returns>
    public override MD_ReferenceSystem_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_ReferenceSystem_Type { ReferenceSystemIdentifier = this.Get<RS_Identifier_Type>("referenceSystemIdentifier", element, options) };
    }
  }
}
