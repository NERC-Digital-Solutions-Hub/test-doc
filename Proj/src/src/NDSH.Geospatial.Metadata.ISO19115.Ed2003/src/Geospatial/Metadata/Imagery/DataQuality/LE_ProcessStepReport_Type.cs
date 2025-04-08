
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:54, @gisvlasta.
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
// <xs:complexType name="LE_ProcessStepReport_Type">
//   <xs:annotation>
//     <xs:documentation>Description: Report of what occurred during the process step - shortName: ProcStepRep</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="fileType" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="LE_ProcessStepReport" type="gmi:LE_ProcessStepReport_Type"/>
// <xs:complexType name="LE_ProcessStepReport_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:LE_ProcessStepReport" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

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
  /// Report of what occurred during the process step.
  /// </summary>
  /// <remarks>ShortName: ProcStepRep</remarks>
  [Serializable]
  [XmlType("LE_ProcessStepReport", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_ProcessStepReport", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_ProcessStepReport")]
  public class LE_ProcessStepReport_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_ProcessStepReport_Type"/>
    /// </summary>
    public LE_ProcessStepReport_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _name = default; // new CharacterString();
      _description = default; // new CharacterString();
      _fileType = default; // new CharacterString();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private CharacterString _name;

    /// <summary>
    /// Name of the processing report.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get {
        return _name;
      }
      set => SetProperty(ref _name, value);
    }

    private CharacterString _description;

    /// <summary>
    /// Textual description of what occurred during the process step.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("description", Order = 1)]
    [JsonProperty("description", Order = 1)]
    public CharacterString Description {
      get {
        return _description;
      }
      set => SetProperty(ref _description, value);
    }

    private CharacterString _fileType;

    /// <summary>
    /// Type of file that contains the processing report.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("fileType", Order = 2)]
    [JsonProperty("fileType", Order = 2)]
    public CharacterString FileType {
      get {
        return _fileType;
      }
      set => SetProperty(ref _fileType, value);
    }

    #endregion

  }

}
