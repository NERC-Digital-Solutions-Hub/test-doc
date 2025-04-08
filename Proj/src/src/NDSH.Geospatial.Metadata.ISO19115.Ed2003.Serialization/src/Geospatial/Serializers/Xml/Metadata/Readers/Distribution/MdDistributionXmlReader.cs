using NDSH.Geospatial.Metadata.Distribution;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Distribution {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Distribution_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdDistributionXmlReader : XmlElementReader<MD_Distribution_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Distribution_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Distribution_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Distribution_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdDistributionXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdDistributionXmlReader() ];
    /// MD_Distribution_Type distribution = XmlElementSerializer.Read&lt;MD_Distribution_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_Distribution_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Distribution_Type {
        DistributionFormat = this.GetCollection<ObservableCollection<MD_Format_Type>>("distributionFormat", element, options),
        Distributor = this.GetCollection<ObservableCollection<MD_Distributor_Type>>("distributor", element, options),
        TransferOptions = this.GetCollection<ObservableCollection<MD_DigitalTransferOptions_Type>>("transferOptions", element, options)
      };
    }
  }
}
