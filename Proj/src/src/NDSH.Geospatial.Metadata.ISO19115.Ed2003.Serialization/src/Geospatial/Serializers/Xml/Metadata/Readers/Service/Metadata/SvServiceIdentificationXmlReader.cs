using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Constraint;
using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.Maintenance;
using NDSH.Geospatial.Metadata.Service.Metadata;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Service.Metadata {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="SV_ServiceIdentification_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class SvServiceIdentificationXmlReader : XmlElementReader<SV_ServiceIdentification_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="SV_ServiceIdentification_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="SV_ServiceIdentification_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="SV_ServiceIdentification_Type"/> instance that represents the XML element.</returns>
    public override SV_ServiceIdentification_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new SV_ServiceIdentification_Type {
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
        ServiceType = this.Get<GenericName>("serviceType", element, options),
        ServiceTypeVersion = this.GetCollection<ObservableCollection<CharacterString>>("serviceTypeVersion", element, options),
        AccessProperties = this.Get<MD_StandardOrderProcess_Type>("accessProperties", element, options),
        Restrictions = this.GetCollection<ObservableCollection<MD_Constraints_Type>>("restrictions", element, options),
        Keywords = this.GetCollection<ObservableCollection<MD_Keywords_Type>>("keywords", element, options),
        Extent = this.GetCollection<ObservableCollection<EX_Extent_Type>>("extent", element, options),
        CouplingType = this.Get<SV_CouplingType_CodeList>("couplingType", element, options),
        CoupledResource = this.GetCollection<ObservableCollection<SV_CoupledResource_Type>>("coupledResource", element, options),
        ContainsOperations = this.GetCollection<ObservableCollection<SV_OperationMetadata_Type>>("containsOperations", element, options),
        OperatesOn = this.GetCollection<ObservableCollection<MD_DataIdentification_Type>>("operatesOn", element, options)
      };
    }
  }
}
