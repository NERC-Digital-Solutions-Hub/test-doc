using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Telephone_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiTelephoneXmlReader : XmlElementReader<CI_Telephone_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Telephone_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_Telephone_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_Telephone_Type"/> instance that represents the XML element.</returns>
    public override CI_Telephone_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_Telephone_Type {
        Voice = this.GetCollection<ObservableCollection<CharacterString>>("voice", element, options),
        Facsimile = this.GetCollection<ObservableCollection<CharacterString>>("facsimile", element, options)
      };
    }
  }
}
