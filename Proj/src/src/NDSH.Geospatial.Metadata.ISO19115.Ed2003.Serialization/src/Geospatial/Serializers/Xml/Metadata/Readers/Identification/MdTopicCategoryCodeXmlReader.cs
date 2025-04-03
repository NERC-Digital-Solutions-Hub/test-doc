
using NDSH.Geospatial.Metadata.Identification;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_TopicCategoryCodeDbEntity"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdTopicCategoryCodeXmlReader : XmlElementReader<MD_TopicCategoryCodeDbEntity> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_TopicCategoryCodeDbEntity"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_TopicCategoryCodeDbEntity"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_TopicCategoryCodeDbEntity"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdTopicCategoryCodeXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdTopicCategoryCodeXmlReader() ];
    /// MD_TopicCategoryCodeDbEntity topicCategoryCode = XmlElementSerializer.Read&lt;MD_TopicCategoryCodeDbEntity&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_TopicCategoryCodeDbEntity Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_TopicCategoryCodeDbEntity { Value = Enum.Parse<MD_TopicCategoryCodes>(element.Value, true) };
    }
  }
}
