using NDSH.Geospatial.Metadata.Citation;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="URL_PropertyType"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class UrlPropertyXmlReader : XmlElementReader<URL_PropertyType> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="URL_PropertyType"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="URL_PropertyType"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="URL_PropertyType"/> instance that represents the XML element.</returns>
    public override URL_PropertyType Read(XElement element, XmlElementSerializerOptions options) {
      return new URL_PropertyType { Url = element.Value };
    }
  }
}
