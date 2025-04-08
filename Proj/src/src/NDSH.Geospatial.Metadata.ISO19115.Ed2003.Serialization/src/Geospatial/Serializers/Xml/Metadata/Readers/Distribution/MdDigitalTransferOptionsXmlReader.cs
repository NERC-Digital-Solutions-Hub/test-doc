using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Distribution;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Distribution {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_DigitalTransferOptions_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdDigitalTransferOptionsXmlReader : XmlElementReader<MD_DigitalTransferOptions_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_DigitalTransferOptions_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_DigitalTransferOptions_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_DigitalTransferOptions_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdDigitalTransferOptionsXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdDigitalTransferOptionsXmlReader() ];
    /// MD_DigitalTransferOptions_Type digitalTransferOptions = XmlElementSerializer.Read&lt;MD_DigitalTransferOptions_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_DigitalTransferOptions_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_DigitalTransferOptions_Type {
        UnitsOfDistribution = this.Get<CharacterString>("unitsOfDistribution", element, options),
        OnLine = this.GetCollection<ObservableCollection<CI_OnlineResource_Type>>("onLine", element, options),
        OffLine = this.Get<MD_Medium_Type>("offLine", element, options)
      };
    }
  }
}
