using NDSH.Geospatial.Metadata.DataQuality;
using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.Maintenance;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.DataQuality {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_Scope_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class DqScopeXmlReader : XmlElementReader<DQ_Scope_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="DQ_Scope_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="DQ_Scope_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="DQ_Scope_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="DqScopeXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new DqScopeXmlReader() ];
    /// DQ_Scope_Type scope = XmlElementSerializer.Read&lt;DQ_Scope_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override DQ_Scope_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new DQ_Scope_Type {
        Level = this.Get<MD_ScopeCode_CodeList>("level", element, options),
        Extent = this.Get<EX_Extent_Type>("extent", element, options),
        LevelDescription = this.GetCollection<ObservableCollection<MD_ScopeDescription_Type>>("levelDescription", element, options)
      };
    }
  }
}
