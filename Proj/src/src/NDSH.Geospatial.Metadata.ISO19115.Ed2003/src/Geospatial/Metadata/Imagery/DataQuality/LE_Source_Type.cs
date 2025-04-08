
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:58, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/dataQualityInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="LE_Source_Type">
//   <xs:annotation>
//     <xs:documentation>Description: information on source of data sets for processing step - shortName: SrcDataset</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:LI_Source_Type">
//       <xs:sequence>
//         <xs:element name="processedLevel" type="gmd:MD_Identifier_PropertyType" minOccurs="0"/>
//         <xs:element name="resolution" type="gmi:LE_NominalResolution_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="LE_Source" type="gmi:LE_Source_Type" substitutionGroup="gmd:LI_Source"/>
// <xs:complexType name="LE_Source_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:LE_Source" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.DataQuality.Lineage;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.DataQuality {

  /// <summary>
  /// Information on source of data sets for processing step.
  /// </summary>
  /// <remarks>ShortName: SrcDataset</remarks>
  [Serializable]
  [XmlType("LE_Source", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_Source", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_Source")]
  public class LE_Source_Type : LI_Source_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Source_Type"/>
    /// </summary>
    public LE_Source_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _processedLevel = default; // new MD_Identifier_Type();
      _resolution = default; // new LE_NominalResolution_PropertyType();

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

    private MD_Identifier_Type _processedLevel;

    /// <summary>
    /// Processing level of the source data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("processedLevel", Order = 0)]
    [JsonProperty("processedLevel", Order = 0)]
    public MD_Identifier_Type ProcessedLevel {
      get {
        return _processedLevel;
      }
      set => SetProperty(ref _processedLevel, value);
    }

    private LE_NominalResolution_CodeList _resolution;

    /// <summary>
    /// Distance between consistent parts (centre, left side, right side) of two adjacent pixels.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("resolution", Order = 1)]
    [JsonProperty("resolution", Order = 1)]
    public LE_NominalResolution_CodeList Resolution {
      get {
        return _resolution;
      }
      set => SetProperty(ref _resolution, value);
    }

    #endregion

  }

}
