
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:25, @gisvlasta.
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
// <xs:complexType name="MI_Objective_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="identifier" 
//                     type="gmd:MD_Identifier_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="priority" 
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="type" 
//                     type="gmi:MI_ObjectiveTypeCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="function" 
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="extent" 
//                     type="gmd:EX_Extent_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="pass" 
//                     type="gmi:MI_PlatformPass_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="sensingInstrument" 
//                     type="gmi:MI_Instrument_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="objectiveOccurrence" 
//                     type="gmi:MI_Event_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Objective" type="gmi:MI_Objective_Type"/>
// <xs:complexType name="MI_Objective_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Objective" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using NDSH.Geospatial.Metadata.Extent;
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
  /// Describes the characteristics, spatial and temporal extent
  /// of the intended object to be observed.
  /// </summary>
  /// <remarks>ShortName: TargetId</remarks>
  [XmlType("MI_Objective", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Objective", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Objective")]
  public class MI_Objective_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Objective_Type"/>.
    /// </summary>
    public MI_Objective_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_Type();
      _priority = default; // new CharacterString();
      _type = default; // new MI_ObjectiveTypeCode_PropertyType();
      _function = default; // new CharacterString();
      _extent = default; // new EX_Extent_Type();
      _pass = default; // new MI_PlatformPass_Type();
      _sensingInstrument = default; // new MI_Instrument_Type();
      _objectiveOccurrence = default; // new MI_Event_Type();

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

    private List<MD_Identifier_Type> _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public List<MD_Identifier_Type> Identifier {
      get {
        return _identifier;
      }
      set => SetProperty(ref _identifier, value);
    }

    private CharacterString _priority;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("priority", Order = 1)]
    [JsonProperty("priority", Order = 1)]
    public CharacterString Priority {
      get {
        return _priority;
      }
      set => SetProperty(ref _priority, value);
    }

    private List<MI_ObjectiveTypeCode_CodeList> _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 2)]
    [JsonProperty("type", Order = 2)]
    public List<MI_ObjectiveTypeCode_CodeList> Type {
      get {
        return _type;
      }
      set => SetProperty(ref _type, value);
    }

    private List<CharacterString> _function;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("function", Order = 3)]
    [JsonProperty("function", Order = 3)]
    public List<CharacterString> Function {
      get {
        return _function;
      }
      set => SetProperty(ref _function, value);
    }

    private List<EX_Extent_Type> _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 4)]
    [JsonProperty("extent", Order = 4)]
    public List<EX_Extent_Type> Extent {
      get {
        return _extent;
      }
      set => SetProperty(ref _extent, value);
    }

    private List<MI_PlatformPass_Type> _pass;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pass", Order = 5)]
    [JsonProperty("pass", Order = 5)]
    public List<MI_PlatformPass_Type> Pass {
      get {
        return _pass;
      }
      set => SetProperty(ref _pass, value);
    }

    private List<MI_Instrument_Type> _sensingInstrument;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sensingInstrument", Order = 6)]
    [JsonProperty("sensingInstrument", Order = 6)]
    public List<MI_Instrument_Type> SensingInstrument {
      get {
        return _sensingInstrument;
      }
      set => SetProperty(ref _sensingInstrument, value);
    }

    private List<MI_Event_Type> _objectiveOccurrence;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("objectiveOccurrence", Order = 7)]
    [JsonProperty("objectiveOccurrence", Order = 7)]
    public List<MI_Event_Type> ObjectiveOccurrence {
      get {
        return _objectiveOccurrence;
      }
      set => SetProperty(ref _objectiveOccurrence, value);
    }

    #endregion

  }

}
