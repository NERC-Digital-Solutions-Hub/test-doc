using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Common;
using NDSH.Geospatial.Metadata.Constraint;
using NDSH.Geospatial.Metadata.DataQuality;
using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.EntitySet;
using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.Localisation;
using NDSH.Geospatial.Metadata.Maintenance;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using NDSH.Geospatial.Metadata.Service.Metadata;
using System.Collections.ObjectModel;
using System.Xml;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.EntitySet {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Metadata_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdMetadataXmlReader : XmlElementReader<MD_Metadata_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Metadata_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Metadata_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Metadata_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdMetadataXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdMetadataXmlReader() ];
    /// MD_Metadata_Type metadata = XmlElementSerializer.Read&lt;MD_Metadata_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_Metadata_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Metadata_Type {
        FileIdentifier = this.Get<CharacterString>("fileIdentifier", element, options) ?? throw new XmlException("Missing 'fileIdentifier' element."),
        Language = this.Get<LanguageCode_CodeList>("language", element, options),
        CharacterSet = this.Get<MD_CharacterSetCode_CodeList>("characterSet", element, options),
        ParentIdentifier = this.Get<CharacterString>("parentIdentifier", element, options),
        HierarchyLevel = this.GetCollection<ObservableCollection<MD_ScopeCode_CodeList>>("hierarchyLevel", element, options),
        HierarchyLevelName = this.GetCollection<ObservableCollection<CharacterString>>("hierarchyLevelName", element, options),
        Contact = this.GetCollection<ObservableCollection<CI_ResponsibleParty_Type>>("contact", element, options),
        MetadataStandardName = this.Get<CharacterString>("metadataStandardName", element, options),
        MetadataStandardVersion = this.Get<CharacterString>("metadataStandardVersion", element, options),
        DataSetURI = this.Get<CharacterString>("dataSetUri", element, options),
        ReferenceSystemInfo = this.GetCollection<ObservableCollection<MD_ReferenceSystem_Type>>("referenceSystemInfo", element, options),
        IdentificationInfo = this.GetCollection<ObservableCollection<AbstractMD_Identification_Type>>("identificationInfo", element, options),
        DistributionInfo = this.Get<MD_Distribution_Type>("distributionInfo", element, options),
        DateStamp = this.Get<DateDbEntity>("dateStamp", element, options),
        DataQualityInfo = this.GetCollection<ObservableCollection<DQ_DataQuality_Type>>("dataQualityInfo", element, options),
        MetadataConstraints = this.GetCollection<ObservableCollection<MD_Constraints_Type>>("metadataConstraints", element, options)
      };
    }
  }
}
