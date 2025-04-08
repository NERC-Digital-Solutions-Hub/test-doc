using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.XmlSchema.Extended;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ConceptualSchema.Primitive.Text {
  /// <summary>
  ///   Reads an <see cref="XElement" /> to a <see cref="CharacterString" />.
  /// </summary>
  public sealed class CharacterStringXmlReader : XmlElementReader<CharacterString> {
    /// <inheritdoc />
    public override CharacterString Read(XElement element, XmlElementSerializerOptions options) {
      return element.Name.LocalName switch {
        "Anchor" => XmlElementSerializer.Read<Anchor_Type>(element, options),
        _ => new CharacterString(element.Value)
      };
    }
  }
}
