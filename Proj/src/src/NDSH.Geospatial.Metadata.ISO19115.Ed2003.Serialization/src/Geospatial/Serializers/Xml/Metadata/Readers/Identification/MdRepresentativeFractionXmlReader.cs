using NDSH.Geospatial.Metadata.Identification;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_RepresentativeFraction_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdRepresentativeFractionXmlReader : XmlElementReader<MD_RepresentativeFraction_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_RepresentativeFraction_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_RepresentativeFraction_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_RepresentativeFraction_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdRepresentativeFractionXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdRepresentativeFractionXmlReader() ];
    /// MD_RepresentativeFraction_Type representativeFraction = XmlElementSerializer.Read&lt;MD_RepresentativeFraction_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_RepresentativeFraction_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_RepresentativeFraction_Type { Denominator = int.TryParse(element.Value, out int value) ? value : 0 };
    }
  }
}
