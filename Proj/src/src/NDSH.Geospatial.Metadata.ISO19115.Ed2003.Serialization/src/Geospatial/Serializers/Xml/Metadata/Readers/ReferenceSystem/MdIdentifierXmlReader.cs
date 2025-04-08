using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ReferenceSystem {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Identifier_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdIdentifierXmlReader : XmlElementReader<MD_Identifier_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Identifier_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Identifier_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Identifier_Type"/> instance that represents the XML element.</returns>
    public override MD_Identifier_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Identifier_Type {
        Authority = this.Get<CI_Citation_Type>("authority", element, options),
        Code = this.Get<CharacterString>("code", element, options)
      };
    }
  }
}
