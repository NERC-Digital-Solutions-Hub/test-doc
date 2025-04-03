
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:30, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          :
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/acquisitionInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_Plan_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="type" 
//                     type="gmi:MI_GeometryTypeCode_PropertyType" minOccurs="0"/>
//         <xs:element name="status" 
//                     type="gmd:MD_ProgressCode_PropertyType"/>
//         <xs:element name="citation" 
//                     type="gmd:CI_Citation_PropertyType"/>
//         <xs:element name="satisfiedRequirement" 
//                     type="gmi:MI_Requirement_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="operation" 
//                     type="gmi:MI_Operation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Plan" type="gmi:MI_Plan_Type"/>
// <xs:complexType name="MI_Plan_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Plan" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Citation;

using NDSH.Geospatial.Metadata.Identification;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.Acquisition {

  /// <summary>
  /// Designations for the planning information related to meeting requirements.
  /// </summary>
  /// <remarks>ShortName: PlanId</remarks>
  [XmlType("MI_Plan", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Plan", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Plan")]
  public class MI_Plan_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Plan_Type"/>.
    /// </summary>
    public MI_Plan_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _type = default; // new MI_GeometryTypeCode_PropertyType();
      _status = default; // new MD_ProgressCode_PropertyType();
      _citation = default; // new CI_Citation_Type();
      _satisfiedRequirement = default; // new MI_Requirement_Type();
      _operation = default; // new MI_Operation_Type();

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

    private MI_GeometryTypeCode_CodeList _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 0)]
    [JsonProperty("type", Order = 0)]
    public MI_GeometryTypeCode_CodeList Type {
      get {
        return _type;
      }
      set => SetProperty(ref _type, value);
    }

    private MD_ProgressCode_CodeList _status;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status", Order = 1)]
    [JsonProperty("status", Order = 1)]
    public MD_ProgressCode_CodeList Status {
      get {
        return _status;
      }
      set => SetProperty(ref _status, value);
    }

    private CI_Citation_Type _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 2)]
    [JsonProperty("citation", Order = 2)]
    public CI_Citation_Type Citation {
      get {
        return _citation;
      }
      set => SetProperty(ref _citation, value);
    }

    private List<MI_Requirement_Type> _satisfiedRequirement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("satisfiedRequirement", Order = 3)]
    [JsonProperty("satisfiedRequirement", Order = 3)]
    public List<MI_Requirement_Type> SatisfiedRequirement {
      get {
        return _satisfiedRequirement;
      }
      set => SetProperty(ref _satisfiedRequirement, value);
    }

    private List<MI_Operation_Type> _operation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operation", Order = 4)]
    [JsonProperty("operation", Order = 4)]
    public List<MI_Operation_Type> Operation {
      get {
        return _operation;
      }
      set => SetProperty(ref _operation, value);
    }

    #endregion

  }

}
