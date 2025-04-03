using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Identification;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_BrowseGraphic_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdBrowseGraphicXmlReader : XmlElementReader<MD_BrowseGraphic_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_BrowseGraphic_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_BrowseGraphic_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_BrowseGraphic_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdBrowseGraphicXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdBrowseGraphicXmlReader() ];
    /// MD_BrowseGraphic_Type browseGraphic = XmlElementSerializer.Read&lt;MD_BrowseGraphic_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_BrowseGraphic_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_BrowseGraphic_Type {
        FileName = this.Get<CharacterString>("fileName", element, options),
        FileDescription = this.Get<CharacterString>("fileDescription", element, options),
        FileType = this.Get<CharacterString>("fileType", element, options)
      };
    }
  }
}
