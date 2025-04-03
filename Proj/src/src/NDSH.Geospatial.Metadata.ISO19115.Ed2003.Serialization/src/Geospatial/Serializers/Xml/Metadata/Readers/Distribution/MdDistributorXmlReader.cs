using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Distribution;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Distribution {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Distributor_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdDistributorXmlReader : XmlElementReader<MD_Distributor_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Distributor_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Distributor_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Distributor_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdDistributorXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdDistributorXmlReader() ];
    /// MD_Distributor_Type distributor = XmlElementSerializer.Read&lt;MD_Distributor_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_Distributor_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Distributor_Type {
        DistributorContact = this.Get<CI_ResponsibleParty_Type>("distributorContact", element, options),
        DistributionOrderProcess = this.GetCollection<ObservableCollection<MD_StandardOrderProcess_Type>>("distributionOrderProcess", element, options),
        DistributorFormat = this.GetCollection<ObservableCollection<MD_Format_Type>>("distributorFormat", element, options),
        DistributorTransferOptions = this.GetCollection<ObservableCollection<MD_DigitalTransferOptions_Type>>("distributorTransferOptions", element, options)
      };
    }
  }
}
