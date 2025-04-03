using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Maintenance;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Maintenance {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_MaintenanceInformation_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdMaintenanceInformationXmlReader : XmlElementReader<MD_MaintenanceInformation_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_MaintenanceInformation_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_MaintenanceInformation_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_MaintenanceInformation_Type"/> instance that represents the XML element.</returns>
    public override MD_MaintenanceInformation_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_MaintenanceInformation_Type {
        MaintenanceAndUpdateFrequency = this.Get<MD_MaintenanceFrequencyCode_CodeList>("maintenanceAndUpdateFrequency", element, options),
        DateOfNextUpdate = this.Get<DateDbEntity>("dateOfNextUpdate", element, options),
        UserDefinedMaintenanceFrequency = this.Get<TM_PeriodDuration_PropertyType>("userDefinedMaintenanceFrequency", element, options),
        UpdateScope = this.GetCollection<ObservableCollection<MD_ScopeCode_CodeList>>("updateScope", element, options),
        UpdateScopeDescription = this.GetCollection<ObservableCollection<MD_ScopeDescription_Type>>("updateScopeDescription", element, options),
        MaintenanceNote = this.GetCollection<ObservableCollection<CharacterString>>("maintenanceNote", element, options),
        Contact = this.GetCollection<ObservableCollection<CI_ResponsibleParty_Type>>("contact", element, options)
      };
    }
  }
}
