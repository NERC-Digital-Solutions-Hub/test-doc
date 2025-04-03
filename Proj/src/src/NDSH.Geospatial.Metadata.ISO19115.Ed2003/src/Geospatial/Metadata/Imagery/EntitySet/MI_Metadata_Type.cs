
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:29, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/metadataEntitySet.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_Metadata_Type">
//   <xs:annotation>
//     <xs:documentation>Description: Root entity that defines information about imagery or gridded data - shortName: IMetadata</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_Metadata_Type">
//       <xs:sequence>
//         <xs:element name="acquisitionInformation" type="gmi:MI_AcquisitionInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Metadata" type="gmi:MI_Metadata_Type" substitutionGroup="gmd:MD_Metadata"/>
// <xs:complexType name="MI_Metadata_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Metadata" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.EntitySet;
using NDSH.Geospatial.Metadata.Imagery.Acquisition;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.EntitySet {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Metadata", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Metadata", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Metadata")]
  public class MI_Metadata_Type : MD_Metadata_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Metadata_Type"/>
    /// </summary>
    public MI_Metadata_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _acquisitionInformation = default; // new List<MI_AcquisitionInformation_Type>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MI_AcquisitionInformation_Type> _acquisitionInformation;

    /// <summary>
    /// Provides information about the acquisition of the data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("acquisitionInformation", Order = 0)]
    [JsonProperty("acquisitionInformation", Order = 0)]
    public List<MI_AcquisitionInformation_Type> AcquisitionInformation {
      get {
        return _acquisitionInformation;
      }
      set => SetProperty(ref _acquisitionInformation, value);
    }

    #endregion

  }

}
