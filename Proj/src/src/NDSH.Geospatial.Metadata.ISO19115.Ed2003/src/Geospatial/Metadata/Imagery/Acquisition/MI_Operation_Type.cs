
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:28, @gisvlasta.
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
// <xs:complexType name="MI_Operation_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="citation" type="gmd:CI_Citation_PropertyType" minOccurs="0"/>
//         <xs:element name="identifier" type="gmd:MD_Identifier_PropertyType" minOccurs="0"/>
//         <xs:element name="status" type="gmd:MD_ProgressCode_PropertyType"/>
//         <xs:element name="type" type="gmi:MI_OperationTypeCode_PropertyType" minOccurs="0"/>
//         <xs:element name="objective" type="gmi:MI_Objective_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="plan" type="gmi:MI_Plan_PropertyType" minOccurs="0"/>
//         <xs:element name="childOperation" type="gmi:MI_Operation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="significantEvent" type="gmi:MI_Event_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="platform" type="gmi:MI_Platform_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Operation" type="gmi:MI_Operation_Type"/>
// <xs:complexType name="MI_Operation_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Operation" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using NDSH.Geospatial.Metadata.Identification;
using NDSH.Geospatial.Metadata.ReferenceSystem;
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
  /// Designations for the operation used to acquire the dataset.
  /// </summary>
  /// <remarks>ShortName: MssnId</remarks>
  [XmlType("MI_Operation", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Operation", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Operation")]
  public class MI_Operation_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Operation_Type"/>.
    /// </summary>
    public MI_Operation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _description = default; // new CharacterString();
      _citation = default; // new CI_Citation_Type();
      _identifier = default; // new MD_Identifier_Type();
      _status = default; // new MD_ProgressCode_PropertyType();
      _type = default; // new MI_OperationTypeCode_PropertyType();
      _objective = default; // new MI_Objective_Type();
      _plan = default; // new MI_Plan_Type();
      _childOperation = default; // new MI_Operation_Type();
      _significantEvent = default; // new MI_Event_Type();
      _platform = default; // new MI_Platform_Type();

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

    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString Description {
      get {
        return _description;
      }
      set => SetProperty(ref _description, value);
    }

    private CI_Citation_Type _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 1)]
    [JsonProperty("citation", Order = 1)]
    public CI_Citation_Type Citation {
      get {
        return _citation;
      }
      set => SetProperty(ref _citation, value);
    }

    private MD_Identifier_Type _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 2)]
    [JsonProperty("identifier", Order = 2)]
    public MD_Identifier_Type Identifier {
      get {
        return _identifier;
      }
      set => SetProperty(ref _identifier, value);
    }

    private MD_ProgressCode_CodeList _status;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status", Order = 3)]
    [JsonProperty("status", Order = 3)]
    public MD_ProgressCode_CodeList Status {
      get {
        return _status;
      }
      set => SetProperty(ref _status, value);
    }

    private MI_OperationTypeCode_CodeList _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 4)]
    [JsonProperty("type", Order = 4)]
    public MI_OperationTypeCode_CodeList Type {
      get {
        return _type;
      }
      set => SetProperty(ref _type, value);
    }

    private List<MI_Objective_Type> _objective;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("objective", Order = 5)]
    [JsonProperty("objective", Order = 5)]
    public List<MI_Objective_Type> Objective {
      get {
        return _objective;
      }
      set => SetProperty(ref _objective, value);
    }

    private MI_Plan_Type _plan;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("plan", Order = 6)]
    [JsonProperty("plan", Order = 6)]
    public MI_Plan_Type Plan {
      get {
        return _plan;
      }
      set => SetProperty(ref _plan, value);
    }

    private List<MI_Operation_Type> _childOperation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("childOperation", Order = 7)]
    [JsonProperty("childOperation", Order = 7)]
    public List<MI_Operation_Type> ChildOperation {
      get {
        return _childOperation;
      }
      set => SetProperty(ref _childOperation, value);
    }

    private List<MI_Event_Type> _significantEvent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("significantEvent", Order = 8)]
    [JsonProperty("significantEvent", Order = 8)]
    public List<MI_Event_Type> SignificantEvent {
      get {
        return _significantEvent;
      }
      set => SetProperty(ref _significantEvent, value);
    }

    private List<MI_Platform_Type> _platform;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("platform", Order = 9)]
    [JsonProperty("platform", Order = 9)]
    public List<MI_Platform_Type> Platform {
      get {
        return _platform;
      }
      set => SetProperty(ref _platform, value);
    }

    #endregion

  }

}
