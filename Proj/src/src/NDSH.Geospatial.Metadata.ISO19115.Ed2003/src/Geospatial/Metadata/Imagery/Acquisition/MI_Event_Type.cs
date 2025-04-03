
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:20, @gisvlasta.
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
// <xs:complexType name="MI_Event_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="identifier" 
//                     type="gmd:MD_Identifier_PropertyType"/>
//         <xs:element name="trigger" 
//                     type="gmi:MI_TriggerCode_PropertyType"/>
//         <xs:element name="context" 
//                     type="gmi:MI_ContextCode_PropertyType"/>
//         <xs:element name="sequence" 
//                     type="gmi:MI_SequenceCode_PropertyType"/>
//         <xs:element name="time" 
//                     type="gco:DateTime_PropertyType"/>
//         <xs:element name="expectedObjective" 
//                     type="gmi:MI_Objective_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="relatedSensor" 
//                     type="gmi:MI_Instrument_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="relatedPass" 
//                     type="gmi:MI_PlatformPass_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Event" type="gmi:MI_Event_Type"/>
// <xs:complexType name="MI_Event_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Event" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;

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
  /// Identification of a significant collection point within an operation.
  /// </summary>
  /// <remarks>
  /// ShortName: Event
  /// </remarks>
  [XmlType("MI_Event", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Event", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Event")]
  public class MI_Event_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Event_Type"/>.
    /// </summary>
    public MI_Event_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_Type();
      _trigger = default; // new MI_TriggerCode_PropertyType();
      _context = default; // new MI_ContextCode_PropertyType();
      _sequence = default; // new MI_SequenceCode_PropertyType();
      _time = default; // new DateTime_PropertyType();
      _expectedObjective = default; // new MI_Objective_Type();
      _relatedSensor = default; // new MI_Instrument_Type();
      _relatedPass = default; // new MI_PlatformPass_Type();

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

    private MD_Identifier_Type _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public MD_Identifier_Type Identifier {
      get {
        return _identifier;
      }
      set => SetProperty(ref _identifier, value);
    }

    private MI_TriggerCode_CodeList _trigger;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("trigger", Order = 1)]
    [JsonProperty("trigger", Order = 1)]
    public MI_TriggerCode_CodeList Trigger {
      get {
        return _trigger;
      }
      set => SetProperty(ref _trigger, value);
    }

    private MI_ContextCode_CodeList _context;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("context", Order = 2)]
    [JsonProperty("context", Order = 2)]
    public MI_ContextCode_CodeList Context {
      get {
        return _context;
      }
      set => SetProperty(ref _context, value);
    }

    private MI_SequenceCode_CodeList _sequence;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sequence", Order = 3)]
    [JsonProperty("sequence", Order = 3)]
    public MI_SequenceCode_CodeList Sequence {
      get {
        return _sequence;
      }
      set => SetProperty(ref _sequence, value);
    }

    private DateTimeDbEntity _time;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("time", Order = 4)]
    [JsonProperty("time", Order = 4)]
    public DateTimeDbEntity Time {
      get {
        return _time;
      }
      set => SetProperty(ref _time, value);
    }

    private List<MI_Objective_Type> _expectedObjective;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("expectedObjective", Order = 5)]
    [JsonProperty("expectedObjective", Order = 5)]
    public List<MI_Objective_Type> ExpectedObjective {
      get {
        return _expectedObjective;
      }
      set => SetProperty(ref _expectedObjective, value);
    }

    private List<MI_Instrument_Type> _relatedSensor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("relatedSensor", Order = 6)]
    [JsonProperty("relatedSensor", Order = 6)]
    public List<MI_Instrument_Type> RelatedSensor {
      get {
        return _relatedSensor;
      }
      set => SetProperty(ref _relatedSensor, value);
    }

    private MI_PlatformPass_Type _relatedPass;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("relatedPass", Order = 7)]
    [JsonProperty("relatedPass", Order = 7)]
    public MI_PlatformPass_Type RelatedPass {
      get {
        return _relatedPass;
      }
      set => SetProperty(ref _relatedPass, value);
    }

    #endregion

  }

}
