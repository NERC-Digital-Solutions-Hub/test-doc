using NDSH.Geospatial.Metadata.DataQuality;
using NDSH.Geospatial.Metadata.DataQuality.Lineage;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.DataQuality {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_DataQuality_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class DqDataQualityXmlReader : XmlElementReader<DQ_DataQuality_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_DataQuality_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="DQ_DataQuality_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="DQ_DataQuality_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="DqDataQualityXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new DqDataQualityXmlReader() ];
    /// DQ_DataQuality_Type dataQuality = XmlElementSerializer.Read&lt;DQ_DataQuality_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override DQ_DataQuality_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new DQ_DataQuality_Type {
        Scope = this.Get<DQ_Scope_Type>("scope", element, options),
        Report = this.GetCollection<ObservableCollection<AbstractDQ_Element_Type>>("report", element, options),
        Lineage = this.Get<LI_Lineage_Type>("lineage", element, options)
      };
    }
  }
}
