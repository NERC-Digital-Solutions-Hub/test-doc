
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataExtension.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_MetadataExtensionInformation_Type">
//   <xs:annotation>
//     <xs:documentation>Information describing metadata extensions.</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="extensionOnLineResource" type="gmd:CI_OnlineResource_PropertyType" minOccurs="0"/>
//         <xs:element name="extendedElementInformation" type="gmd:MD_ExtendedElementInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_MetadataExtensionInformation" type="gmd:MD_MetadataExtensionInformation_Type"/>
// <xs:complexType name="MD_MetadataExtensionInformation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_MetadataExtensionInformation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata.Extension {

  /// <summary>
  /// Information describing metadata extensions.
  /// </summary>
  [Serializable]
  //[XmlType("MD_MetadataExtensionInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_MetadataExtensionInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_MetadataExtensionInformation")]
  public class MD_MetadataExtensionInformation_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MetadataExtensionInformation_Type"/>.
    /// </summary>
    public MD_MetadataExtensionInformation_Type() {
      _extensionOnLineResource = default; //  new CI_OnlineResource_Type();
      _extendedElementInformation = default; //  new List<MD_ExtendedElementInformation_Type>();
    }

    #endregion

    #region Public Properties

    private CI_OnlineResource_Type? _extensionOnLineResource;

    /// <summary>
    /// Information about on-line sources containing the community profile name and the extended metadata elements.
    /// Information for all new metadata element.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("extensionOnLineResource", Order = 0)]
    [JsonProperty("extensionOnLineResource", Order = 0)]
    public CI_OnlineResource_Type? ExtensionOnLineResource {
      get => _extensionOnLineResource;
      set => SetProperty(ref _extensionOnLineResource, value);
    }

    private ObservableCollection<MD_ExtendedElementInformation_Type>? _extendedElementInformation;

    /// <summary>
    /// Provides information about a new metadata element, not found in ISO 19115,
    /// which is required to describe geographic data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("extendedElementInformation", Order = 1)]
    [JsonProperty("extendedElementInformation", Order = 1)]
    public ObservableCollection<MD_ExtendedElementInformation_Type>? ExtendedElementInformation {
      get => _extendedElementInformation;
      set => SetProperty(ref _extendedElementInformation, value);
    }

    #endregion

  }

}
