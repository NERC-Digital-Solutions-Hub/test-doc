using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_OnlineResource_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiOnlineResourceXmlReader : XmlElementReader<CI_OnlineResource_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_OnlineResource_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_OnlineResource_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_OnlineResource_Type"/> instance that represents the XML element.</returns>
    public override CI_OnlineResource_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_OnlineResource_Type {
        Linkage = this.Get<URL_PropertyType>("linkage", element, options),
        Protocol = this.Get<CharacterString>("protocol", element, options),
        ApplicationProfile = this.Get<CharacterString>("applicationProfile", element, options),
        Name = this.Get<CharacterString>("name", element, options),
        Description = this.Get<CharacterString>("description", element, options),
        Function = this.Get<CI_OnLineFunctionCode_CodeList>("function", element, options)
      };
    }
  }
}
