using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ReferenceSystem {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="RS_Identifier_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class RsIdentifierXmlReader : XmlElementReader<RS_Identifier_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="RS_Identifier_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="RS_Identifier_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="RS_Identifier_Type"/> instance that represents the XML element.</returns>
    public override RS_Identifier_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new RS_Identifier_Type {
        CodeSpace = this.Get<CharacterString>("codeSpace", element, options),
        Version = this.Get<CharacterString>("version", element, options)
      };
    }
  }
}
