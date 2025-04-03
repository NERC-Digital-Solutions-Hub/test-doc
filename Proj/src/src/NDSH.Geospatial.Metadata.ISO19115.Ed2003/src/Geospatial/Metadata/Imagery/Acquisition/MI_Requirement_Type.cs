
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 17:17, @gisvlasta.
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
// <xs:complexType name="MI_Requirement_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="citation" type="gmd:CI_Citation_PropertyType" minOccurs="0"/>
//         <xs:element name="identifier" type="gmd:MD_Identifier_PropertyType"/>
//         <xs:element name="requestor" type="gmd:CI_ResponsibleParty_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="recipient" type="gmd:CI_ResponsibleParty_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="priority" type="gmi:MI_PriorityCode_PropertyType"/>
//         <xs:element name="requestedDate" type="gmi:MI_RequestedDate_PropertyType"/>
//         <xs:element name="expiryDate" type="gco:DateTime_PropertyType"/>
//         <xs:element name="satisifiedPlan" type="gmi:MI_Plan_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Requirement" type="gmi:MI_Requirement_Type"/>
// <xs:complexType name="MI_Requirement_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Requirement" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Metadata.Citation;

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
  /// Requirement to be satisfied by the planned data acquisition.
  /// </summary>
  /// <remarks>ShortName: Requirement</remarks>
  [Serializable]
  [XmlType("MI_Requirement", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Requirement", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Requirement")]
  public class MI_Requirement_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Requirement_Type"/>.
    /// </summary>
    public MI_Requirement_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_Type();
      _identifier = default; // new MD_Identifier_Type();
      _requestor = default; // new List<CI_ResponsibleParty_Type>();
      _recipient = default; // new List<CI_ResponsibleParty_Type?();
      _priority = default; // new MI_PriorityCode_PropertyType();
      _requestedDate = default; // new MI_RequestedDate_Type();
      _expiryDate = default; // new DateTime_PropertyType();
      _satisfiedPlan = default; // new List<MI_Plan_Type>();

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

    private CI_Citation_Type _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
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
    [XmlElement("identifier", Order = 1)]
    [JsonProperty("identifier", Order = 1)]
    public MD_Identifier_Type Identifier {
      get {
        return _identifier;
      }
      set => SetProperty(ref _identifier, value);
    }

    private List<CI_ResponsibleParty_Type> _requestor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("requestor", Order = 2)]
    [JsonProperty("requestor", Order = 2)]
    public List<CI_ResponsibleParty_Type> Requestor {
      get {
        return _requestor;
      }
      set => SetProperty(ref _requestor, value);
    }

    private List<CI_ResponsibleParty_Type> _recipient;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("recipient", Order = 3)]
    [JsonProperty("recipient", Order = 3)]
    public List<CI_ResponsibleParty_Type> Recipient {
      get {
        return _recipient;
      }
      set => SetProperty(ref _recipient, value);
    }

    private MI_PriorityCode_CodeList _priority;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("priority", Order = 4)]
    [JsonProperty("priority", Order = 4)]
    public MI_PriorityCode_CodeList Priority {
      get {
        return _priority;
      }
      set => SetProperty(ref _priority, value);
    }

    private MI_RequestedDate_Type _requestedDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("requestedDate", Order = 5)]
    [JsonProperty("requestedDate", Order = 5)]
    public MI_RequestedDate_Type RequestedDate {
      get {
        return _requestedDate;
      }
      set => SetProperty(ref _requestedDate, value);
    }

    private DateTimeDbEntity _expiryDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("expiryDate", Order = 6)]
    [JsonProperty("expiryDate", Order = 6)]
    public DateTimeDbEntity ExpiryDate {
      get {
        return _expiryDate;
      }
      set => SetProperty(ref _expiryDate, value);
    }

    private List<MI_Plan_Type> _satisfiedPlan;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("satisifiedPlan", Order = 7)]
    [JsonProperty("satisifiedPlan", Order = 7)]
    public List<MI_Plan_Type> SatisfiedPlan {
      get {
        return _satisfiedPlan;
      }
      set => SetProperty(ref _satisfiedPlan, value);
    }

    #endregion

  }

}
