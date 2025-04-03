
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:18, @gisvlasta.
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
// <xs:complexType name="MI_AcquisitionInformation_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="acquisitionRequirement"
//                     type="gmi:MI_Requirement_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="objective"
//                     type="gmi:MI_Objective_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="instrument"
//                     type="gmi:MI_Instrument_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="acquisitionPlan"
//                     type="gmi:MI_Plan_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="operation"
//                     type="gmi:MI_Operation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="platform"
//                     type="gmi:MI_Platform_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="environmentalConditions"
//                     type="gmi:MI_EnvironmentalRecord_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_AcquisitionInformation" type="gmi:MI_AcquisitionInformation_Type"/>
// <xs:complexType name="MI_AcquisitionInformation_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_AcquisitionInformation" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


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
  /// Designations for the measuring instruments and their bands,
  /// the platform carrying them, and the mission to which the data contributes.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Platform_and_Instrument_Identification, Mission_Information.</para>
  /// <para>ShortName: PltfrmInstId</para>
  /// </remarks>
  [XmlType("MI_AcquisitionInformation", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_AcquisitionInformation", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_AcquisitionInformation")]
  public class MI_AcquisitionInformation_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_AcquisitionInformation_Type"/>.
    /// </summary>
    public MI_AcquisitionInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _acquisitionRequirement = default; // new MI_Requirement_Type();
      _objective = default; // new MI_Objective_Type();
      _instrument = default; // new MI_Instrument_Type();
      _acquisitionPlan = default; // new MI_Plan_Type();
      _operation = default; // new MI_Operation_Type();
      _platform = default; // new MI_Platform_Type();
      _environmentalConditions = default; // new MI_EnvironmentalRecord_Type();

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

    private List<MI_Requirement_Type> _acquisitionRequirement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("acquisitionRequirement", Order = 0)]
    [JsonProperty("acquisitionRequirement", Order = 0)]
    public List<MI_Requirement_Type> AcquisitionRequirement {
      get {
        return _acquisitionRequirement;
      }
      set => SetProperty(ref _acquisitionRequirement, value);
    }

    private List<MI_Objective_Type> _objective;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("objective", Order = 1)]
    [JsonProperty("objective", Order = 1)]
    public List<MI_Objective_Type> Objective {
      get {
        return _objective;
      }
      set => SetProperty(ref _objective, value);
    }

    private List<MI_Instrument_Type> _instrument;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("instrument", Order = 2)]
    [JsonProperty("instrument", Order = 2)]
    public List<MI_Instrument_Type> Instrument {
      get {
        return _instrument;
      }
      set => SetProperty(ref _instrument, value);
    }

    private List<MI_Plan_Type> _acquisitionPlan;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("acquisitionPlan", Order = 3)]
    [JsonProperty("acquisitionPlan", Order = 3)]
    public List<MI_Plan_Type> AcquisitionPlan {
      get {
        return _acquisitionPlan;
      }
      set => SetProperty(ref _acquisitionPlan, value);
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

    private List<MI_Platform_Type> _platform;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("platform", Order = 5)]
    [JsonProperty("platform", Order = 5)]
    public List<MI_Platform_Type> Platform {
      get {
        return _platform;
      }
      set => SetProperty(ref _platform, value);
    }

    private MI_EnvironmentalRecord_Type _environmentalConditions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("environmentalConditions", Order = 6)]
    [JsonProperty("environmentalConditions", Order = 6)]
    public MI_EnvironmentalRecord_Type EnvironmentalConditions {
      get {
        return _environmentalConditions;
      }
      set => SetProperty(ref _environmentalConditions, value);
    }

    #endregion

  }

}
