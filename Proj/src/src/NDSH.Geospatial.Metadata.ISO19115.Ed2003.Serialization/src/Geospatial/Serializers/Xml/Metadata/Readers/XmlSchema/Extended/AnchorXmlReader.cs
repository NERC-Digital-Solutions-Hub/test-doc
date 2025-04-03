using NDSH.Geospatial.Metadata.XmlSchema.Extended;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.XmlSchema.Extended {
  /// <summary>
  ///   Reads an <see cref="XElement" />to a <see cref="Anchor_Type" />.
  /// </summary>
  public sealed class AnchorXmlReader : XmlElementReader<Anchor_Type> {
    /// <inheritdoc />
    public override Anchor_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new Anchor_Type {
        Value = element.Value,
        Type = element.GetAttributeByLocalName("type"),
        Href = element.GetAttributeByLocalName("href"),
        Role = element.GetAttributeByLocalName("role"),
        Title = element.GetAttributeByLocalName("title"),
        Show = element.GetAttributeByLocalName("show"),
        Actuate = element.GetAttributeByLocalName("actuate"),
        ArcRole = element.GetAttributeByLocalName("arcrole")
      };
    }
  }
}
