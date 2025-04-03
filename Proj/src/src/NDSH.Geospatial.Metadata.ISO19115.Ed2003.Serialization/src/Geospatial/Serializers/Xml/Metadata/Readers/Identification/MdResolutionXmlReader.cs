using NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure;
using NDSH.Geospatial.Gml.Measures;
using NDSH.Geospatial.Metadata.Identification;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Resolution_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdResolutionXmlReader : XmlElementReader<MD_Resolution_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Resolution_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Resolution_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Resolution_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdResolutionXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdResolutionXmlReader() ];
    /// MD_Resolution_Type resolution = XmlElementSerializer.Read&lt;MD_Resolution_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_Resolution_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Resolution_Type {
        EquivalentScale = this.Get<MD_RepresentativeFraction_Type>("equivalentScale", element, options),
        Distance = this.Get<Distance_PropertyType>("distance", element, options)
      };
    }
  }
}
