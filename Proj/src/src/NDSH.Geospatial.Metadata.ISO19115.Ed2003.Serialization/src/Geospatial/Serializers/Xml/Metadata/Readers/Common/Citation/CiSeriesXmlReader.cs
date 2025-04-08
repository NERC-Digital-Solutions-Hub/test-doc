using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Series_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiSeriesXmlReader : XmlElementReader<CI_Series_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Series_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_Series_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_Series_Type"/> instance that represents the XML element.</returns>
    public override CI_Series_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_Series_Type {
        Name = this.Get<CharacterString>("name", element, options),
        IssueIdentification = this.Get<CharacterString>("issueIdentification", element, options),
        Page = this.Get<CharacterString>("page", element, options)
      };
    }
  }
}
