using NDSH.Geospatial.Metadata.DataQuality.LogicalConsistency;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.DataQuality.LogicalConsistency {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_DomainConsistency_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class DqDomainConsistencyXmlReader : XmlElementReader<DQ_DomainConsistency_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_DomainConsistency_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="DQ_DomainConsistency_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="DQ_DomainConsistency_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="DqDomainConsistencyXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new DqDomainConsistencyXmlReader() ];
    /// DQ_DomainConsistency_Type domainConsistency = XmlElementSerializer.Read&lt;DQ_DomainConsistency_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override DQ_DomainConsistency_Type Read(XElement element, XmlElementSerializerOptions options) => new();
  }
}
