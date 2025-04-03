using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Identification;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Keywords_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdKeywordsXmlReader : XmlElementReader<MD_Keywords_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Keywords_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Keywords_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Keywords_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdKeywordsXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdKeywordsXmlReader() ];
    /// MD_Keywords_Type keywords = XmlElementSerializer.Read&lt;MD_Keywords_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_Keywords_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Keywords_Type {
        Keyword = this.GetCollection<ObservableCollection<CharacterString>>("keyword", element, options),
        Type = this.Get<MD_KeywordTypeCode_CodeList>("type", element, options),
        ThesaurusName = this.Get<CI_Citation_Type>("thesaurusName", element, options)
      };
    }
  }
}
