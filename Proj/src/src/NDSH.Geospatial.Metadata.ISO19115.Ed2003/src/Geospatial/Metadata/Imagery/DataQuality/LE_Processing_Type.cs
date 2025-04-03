
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:46, @gisvlasta.
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
// <xs:complexType name="LE_Processing_Type">
//   <xs:annotation>
//     <xs:documentation>Description: Comprehensive information about the procedure(s), process(es) and algorithm(s) applied in the process step - shortName: Procsg</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="identifier" type="gmd:MD_Identifier_PropertyType"/>
//         <xs:element name="softwareReference" type="gmd:CI_Citation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="procedureDescription" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="documentation" type="gmd:CI_Citation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="runTimeParameters" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="algorithm" type="gmi:LE_Algorithm_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="LE_Processing" type="gmi:LE_Processing_Type"/>
// <xs:complexType name="LE_Processing_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:LE_Processing" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
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

namespace NDSH.Geospatial.Metadata.Imagery.DataQuality {

  /// <summary>
  /// Description: Comprehensive information about the procedure(s),
  /// process(es) and algorithm(s) applied in the process step.
  /// </summary>
  /// <remarks>ShortName: Procsg</remarks>
  [Serializable]
  [XmlType("LE_Processing", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_Processing", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_Processing")]
  public class LE_Processing_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Processing_Type"/>
    /// </summary>
    public LE_Processing_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_Type();
      _softwareReference = default; // new List<CI_Citation_Type>();
      _procedureDescription = default; // new CharacterString();
      _documentation = default; // new List<CI_Citation_Type>();
      _runTimeParameters = default; // new CharacterString();
      _algorithm = default; // new List<LE_Algorithm_Type>();

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
    /// Information to identify the processing package that produced the data.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public MD_Identifier_Type Identifier {
      get {
        return _identifier;
      }
      set => SetProperty(ref _identifier, value);
    }

    private List<CI_Citation_Type> _softwareReference;

    /// <summary>
    /// Reference to document describing processing software.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("softwareReference", Order = 1)]
    [JsonProperty("softwareReference", Order = 1)]
    public List<CI_Citation_Type> SoftwareReference {
      get {
        return _softwareReference;
      }
      set => SetProperty(ref _softwareReference, value);
    }

    private CharacterString _procedureDescription;

    /// <summary>
    /// Additional details about the processing procedures.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("procedureDescription", Order = 2)]
    [JsonProperty("procedureDescription", Order = 2)]
    public CharacterString ProcedureDescription {
      get {
        return _procedureDescription;
      }
      set => SetProperty(ref _procedureDescription, value);
    }

    private List<CI_Citation_Type> _documentation;

    /// <summary>
    /// Reference to documentation describing the processing.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("documentation", Order = 3)]
    [JsonProperty("documentation", Order = 3)]
    public List<CI_Citation_Type> Documentation {
      get {
        return _documentation;
      }
      set => SetProperty(ref _documentation, value);
    }

    private CharacterString _runTimeParameters;

    /// <summary>
    /// Parameters to control the processing operations, entered at runtime.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    [XmlElement("runTimeParameters", Order = 4)]
    [JsonProperty("runTimeParameters", Order = 4)]
    public CharacterString RunTimeParameters {
      get {
        return _runTimeParameters;
      }
      set => SetProperty(ref _runTimeParameters, value);
    }

    private List<LE_Algorithm_Type> _algorithm;

    /// <summary>
    /// Details of the methodology by which geographic information was derived from the instrument readings.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("algorithm", Order = 5)]
    [JsonProperty("algorithm", Order = 5)]
    public List<LE_Algorithm_Type> Algorithm {
      get {
        return _algorithm;
      }
      set => SetProperty(ref _algorithm, value);
    }

    #endregion

  }

}
