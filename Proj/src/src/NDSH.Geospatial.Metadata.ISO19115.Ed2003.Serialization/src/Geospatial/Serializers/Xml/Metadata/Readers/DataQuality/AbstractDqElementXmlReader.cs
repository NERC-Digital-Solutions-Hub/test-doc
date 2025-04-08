
using NDSH.Geospatial.Metadata.DataQuality;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.DataQuality {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="AbstractDQ_Element_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class AbstractDqElementXmlReader : XmlElementReader<AbstractDQ_Element_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="AbstractDQ_Element_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="AbstractDQ_Element_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="AbstractDQ_Element_Type"/> instance that represents the XML element.</returns>
    public override AbstractDQ_Element_Type Read(XElement element, XmlElementSerializerOptions options) {
      return element.Name.LocalName switch {
        _ => null // TODO: This needs to be changed once derived classes are implemented.
      };
    }
  }
}
