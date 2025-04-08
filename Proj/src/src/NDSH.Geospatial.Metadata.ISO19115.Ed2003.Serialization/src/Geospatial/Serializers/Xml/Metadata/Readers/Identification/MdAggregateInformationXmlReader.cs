using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_AggregateInformation_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdAggregateInformationXmlReader : XmlElementReader<MD_AggregateInformation_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_AggregateInformation_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_AggregateInformation_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_AggregateInformation_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdAggregateInformationXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdAggregateInformationXmlReader() ];
    /// MD_AggregateInformation_Type aggregateInformation = XmlElementSerializer.Read&lt;MD_AggregateInformation_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_AggregateInformation_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_AggregateInformation_Type {
        AggregateDataSetName = this.Get<CI_Citation_Type>("aggregateDataSetName", element, options),
        AggregateDataSetIdentifier = this.Get<MD_Identifier_Type>("aggregateDataSetIdentifier", element, options),
        AssociationType = this.Get<DS_AssociationTypeCode_CodeList>("associationType", element, options),
        InitiativeType = this.Get<DS_InitiativeTypeCode_CodeList>("initiativeType", element, options)
      };
    }
  }
}
