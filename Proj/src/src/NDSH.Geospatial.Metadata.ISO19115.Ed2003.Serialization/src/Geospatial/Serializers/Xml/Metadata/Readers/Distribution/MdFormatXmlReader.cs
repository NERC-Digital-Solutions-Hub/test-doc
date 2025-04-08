using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Distribution;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Distribution {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Format_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdFormatXmlReader : XmlElementReader<MD_Format_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Format_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Format_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Format_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdFormatXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdFormatXmlReader() ];
    /// MD_Format_Type format = XmlElementSerializer.Read&lt;MD_Format_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_Format_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Format_Type {
        Name = this.Get<CharacterString>("name", element, options),
        Version = this.Get<CharacterString>("version", element, options),
        AmendmentNumber = this.Get<CharacterString>("amendmentNumber", element, options),
        Specification = this.Get<CharacterString>("specification", element, options),
        FileDecompressionTechnique = this.Get<CharacterString>("fileDecompressionTechnique", element, options),
        FormatDistributor = this.GetCollection<ObservableCollection<MD_Distributor_Type>>("formatDistributor", element, options)
      };
    }
  }
}
