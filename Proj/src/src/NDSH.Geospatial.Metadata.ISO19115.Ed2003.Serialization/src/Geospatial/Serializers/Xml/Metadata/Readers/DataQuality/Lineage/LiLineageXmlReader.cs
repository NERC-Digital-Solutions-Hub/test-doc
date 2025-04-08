using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.DataQuality.Lineage;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.DataQuality.Lineage {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="LI_Lineage_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class LiLineageXmlReader : XmlElementReader<LI_Lineage_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="LI_Lineage_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="LI_Lineage_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="LI_Lineage_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="LiLineageXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new LiLineageXmlReader() ];
    /// LI_Lineage_Type lineage = XmlElementSerializer.Read&lt;LI_Lineage_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override LI_Lineage_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new LI_Lineage_Type {
        Statement = this.Get<CharacterString>("statement", element, options),
        ProcessStep = this.GetCollection<ObservableCollection<LI_ProcessStep_Type>>("processStep", element, options),
        Source = this.GetCollection<ObservableCollection<LI_Source_Type>>("source", element, options)
      };
    }
  }
}
