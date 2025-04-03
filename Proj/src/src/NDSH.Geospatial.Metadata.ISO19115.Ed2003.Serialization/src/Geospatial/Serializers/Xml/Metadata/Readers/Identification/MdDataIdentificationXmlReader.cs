using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Constraint;
using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.Maintenance;
using System.Collections;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Identification {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_DataIdentification_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdDataIdentificationXmlReader : XmlElementReader<MD_DataIdentification_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_DataIdentification_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_DataIdentification_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_DataIdentification_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdDataIdentificationXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdDataIdentificationXmlReader() ];
    /// MD_DataIdentification_Type dataIdentification = XmlElementSerializer.Read&lt;MD_DataIdentification_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_DataIdentification_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_DataIdentification_Type {
        Abstract = this.Get<CharacterString>("abstract", element, options),
        Citation = this.Get<CI_Citation_Type>("citation", element, options),
        Purpose = this.Get<CharacterString>("purpose", element, options),
        Credit = this.GetCollection<ObservableCollection<CharacterString>>("credit", element, options),
        Status = this.GetCollection<ObservableCollection<MD_ProgressCode_CodeList>>("status", element, options),
        PointOfContact = this.GetCollection<ObservableCollection<CI_ResponsibleParty_Type>>("pointOfContact", element, options),
        ResourceMaintenance = this.GetCollection<ObservableCollection<MD_MaintenanceInformation_Type>>("resourceMaintenance", element, options),
        GraphicOverview = this.GetCollection<ObservableCollection<MD_BrowseGraphic_Type>>("graphicOverview", element, options),
        ResourceFormat = this.GetCollection<ObservableCollection<MD_Format_Type>>("resourceFormat", element, options),
        DescriptiveKeywords = this.GetCollection<ObservableCollection<MD_Keywords_Type>>("descriptiveKeywords", element, options),
        ResourceSpecificUsage = this.GetCollection<ObservableCollection<MD_Usage_Type>>("resourceSpecificUsage", element, options),
        ResourceConstraints = this.GetCollection<ObservableCollection<MD_Constraints_Type>>("resourceConstraints", element, options),
        AggregationInfo = this.GetCollection<ObservableCollection<MD_AggregateInformation_Type>>("aggregationInfo", element, options),
        SpatialRepresentationType =
          this.GetCollection<ObservableCollection<MD_SpatialRepresentationTypeCode_CodeList>>("spatialRepresentationType", element, options),
        SpatialResolution = this.GetCollection<ObservableCollection<MD_Resolution_Type>>("spatialResolution", element, options),
        Language = this.GetCollection<ObservableCollection<CharacterString>>("language", element, options),
        CharacterSet = this.GetCollection<ObservableCollection<MD_CharacterSetCode_CodeList>>("characterSet", element, options),
        TopicCategory = this.GetCollection<ObservableCollection<MD_TopicCategoryCodeDbEntity>>("topicCategory", element, options),
        EnvironmentDescription = this.Get<CharacterString>("environmentDescription", element, options),
        Extent = this.GetCollection<ObservableCollection<EX_Extent_Type>>("extent", element, options),
        SupplementalInformation = this.Get<CharacterString>("supplementalInformation", element, options)
      };
    }
  }
}
