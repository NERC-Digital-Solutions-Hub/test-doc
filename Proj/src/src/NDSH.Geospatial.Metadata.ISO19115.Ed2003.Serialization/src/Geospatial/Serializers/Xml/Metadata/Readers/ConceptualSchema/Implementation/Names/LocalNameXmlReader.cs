using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ConceptualSchema.Implementation.Names {
  /// <summary>
  ///   Reads an <see cref="XElement" /> to a <see cref="LocalName" />.
  /// </summary>
  public sealed class LocalNameXmlReader : XmlElementReader<LocalName> {
    /// <inheritdoc />
    public override LocalName Read(XElement element, XmlElementSerializerOptions options) => new() { Value = element.Value };

    /// <inheritdoc />
    public override bool CanRead(Type type) => base.CanRead(type) || type == typeof(GenericName);
  }
}
