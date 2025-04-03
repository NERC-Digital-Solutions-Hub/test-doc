using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Identification;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Usage_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdUsageXmlReader : XmlElementReader<MD_Usage_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Usage_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Usage_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Usage_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdUsageXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdUsageXmlReader() ];
    /// MD_Usage_Type usage = XmlElementSerializer.Read&lt;MD_Usage_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_Usage_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Usage_Type {
        SpecificUsage = this.Get<CharacterString>("specificUsage", element, options),
        UsageDateTime = this.Get<DateTimeDbEntity>("usageDateTime", element, options),
        UserDeterminedLimitations = this.Get<CharacterString>("userDeterminedLimitations", element, options),
        UserContactInfo = this.GetCollection<ObservableCollection<CI_ResponsibleParty_Type>>("userContactInfo", element, options)
      };
    }
  }
}
