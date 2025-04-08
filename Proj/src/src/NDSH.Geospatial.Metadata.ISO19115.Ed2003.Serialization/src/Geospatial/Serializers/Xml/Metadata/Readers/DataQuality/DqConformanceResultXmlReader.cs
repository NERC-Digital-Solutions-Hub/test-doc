using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.DataQuality;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.DataQuality {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_ConformanceResult_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class DqConformanceResultXmlReader : XmlElementReader<DQ_ConformanceResult_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_ConformanceResult_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="DQ_ConformanceResult_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="DQ_ConformanceResult_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="DqConformanceResultXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new DqConformanceResultXmlReader() ];
    /// DQ_ConformanceResult_Type conformanceResult = XmlElementSerializer.Read&lt;DQ_ConformanceResult_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override DQ_ConformanceResult_Type Read(XElement element, XmlElementSerializerOptions options) {
      bool.TryParse(element.Elements().Where(element => element.Name.LocalName == "pass").FirstOrDefault()?.Value, out bool passValue);
      return new DQ_ConformanceResult_Type {
        Specification = this.Get<CI_Citation_Type>("specification", element, options),
        Explanation = this.Get<CharacterString>("explanation", element, options),
        Pass = passValue
      };
    }
  }
}
