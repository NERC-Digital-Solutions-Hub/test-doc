
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/content.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_FeatureCatalogueDescription_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractMD_ContentInformation_Type">
//       <xs:sequence>
//         <xs:element name="complianceCode" type="gco:Boolean_PropertyType" minOccurs="0"/>
//         <xs:element name="language" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="includedWithDataset" type="gco:Boolean_PropertyType"/>
//         <xs:element name="featureTypes" type="gco:GenericName_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="featureCatalogueCitation" type="gmd:CI_Citation_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_FeatureCatalogueDescription"
//             type="gmd:MD_FeatureCatalogueDescription_Type" substitutionGroup="gmd:AbstractMD_ContentInformation"/>
// <xs:complexType name="MD_FeatureCatalogueDescription_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_FeatureCatalogueDescription"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Content {

  /// <summary>
  /// Information identifying the feature catalogue.
  /// </summary>
  [Serializable]
  //[XmlType("MD_FeatureCatalogueDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_FeatureCatalogueDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_FeatureCatalogueDescription")]
  public class MD_FeatureCatalogueDescription_Type : AbstractMD_ContentInformation_Type {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_FeatureCatalogueDescription_Type"/>.
    /// </summary>
    public MD_FeatureCatalogueDescription_Type() {
      _complianceCode = default; //  new Boolean_PropertyType();
      _language = default; //  new List<CharacterString>();
      _includedWithDataset = default; //  new Boolean_PropertyType();
      _featureTypes = default; //  new List<GenericName_PropertyType>();
      _featureCatalogueCitation = default; //  new List<CI_Citation_Type>();
    }

    #endregion

    #region Public Properties

    private bool? _complianceCode;

    /// <summary>
    /// Indication of whether or not the cited feature catalogue complies with ISO 19110.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("complianceCode", Order = 0)]
    [JsonProperty("complianceCode", Order = 0)]
    public bool? ComplianceCode {
      get => _complianceCode;
      // TODO: SetProperty
      set {
        if (_complianceCode == value) {
          return;
        }
        if (/*_complianceCode == null ||*/_complianceCode.Equals(value) != true) {
          _complianceCode = value;
          OnPropertyChanged();
        }
      }
    }

    private ObservableCollection<CharacterString>? _language;

    /// <summary>
    /// Language(s) used within the catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("language", Order = 1)]
    [JsonProperty("language", Order = 1)]
    public ObservableCollection<CharacterString>? Language {
      get => _language;
      set => SetProperty(ref _language, value);
    }

    private bool _includedWithDataset;

    /// <summary>
    /// Indication of whether or not the feature catalogue is included with the dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("includedWithDataset", Order = 2)]
    [JsonProperty("includedWithDataset", Order = 2)]
    public bool IncludedWithDataset {
      get => _includedWithDataset;
      // TODO: SetProperty
      set {
        if (_includedWithDataset == value) {
          return;
        }
        if (/*_includedWithDataset == null || */_includedWithDataset.Equals(value) != true) {
          _includedWithDataset = value;
          OnPropertyChanged();
        }
      }
    }

    private ObservableCollection<GenericName>? _featureTypes;

    /// <summary>
    /// Subset of feature types from cited feature catalogue occurring in dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("featureTypes", Order = 3)]
    [JsonProperty("featureTypes", Order = 3)]
    public ObservableCollection<GenericName>? FeatureTypes {
      get => _featureTypes;
      set => SetProperty(ref _featureTypes, value);
    }

    private ObservableCollection<CI_Citation_Type> _featureCatalogueCitation;

    /// <summary>
    /// Complete bibliographic reference to one or more external feature catalogues.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("featureCatalogueCitation", Order = 4)]
    [JsonProperty("featureCatalogueCitation", Order = 4)]
    public ObservableCollection<CI_Citation_Type> FeatureCatalogueCitation {
      get => _featureCatalogueCitation;
      set => SetProperty(ref _featureCatalogueCitation, value);
    }

    #endregion

  }

}
