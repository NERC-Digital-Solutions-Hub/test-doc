using NDSH.Geospatial.Metadata;
using System.Xml;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common {
  /// <summary>
  ///   Readers an <see cref="XElement" /> to a <see cref="CodeListValue_Type" />.
  /// </summary>
  public sealed class CodeListValueXmlReader<TCodeListValue> : XmlElementReader<TCodeListValue>
    where TCodeListValue : CodeListValue_Type, new() {
    /// <inheritdoc />
    public override TCodeListValue Read(XElement element, XmlElementSerializerOptions options) {
      string codeList = element.GetAttributeByLocalName("codeList") ?? throw new XmlException("Missing 'codeList' attribute.");
      string codeListValue = element.GetAttributeByLocalName("codeListValue") ?? throw new XmlException("Missing 'codeListValue' attribute.");
      string? codeSpace = element.GetAttributeByLocalName("codeSpace");
      string? value = element.Value;

      return new TCodeListValue { CodeList = codeList, CodeListValue = codeListValue, CodeSpace = codeSpace, Value = value };
    }

    /// <inheritdoc />
    public override bool CanRead(Type type) => base.CanRead(type) || type.IsAssignableFrom(typeof(CodeListValue_Type));
  }
}
