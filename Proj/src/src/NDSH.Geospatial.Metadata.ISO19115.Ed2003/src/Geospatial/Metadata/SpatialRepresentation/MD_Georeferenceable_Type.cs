
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:38, @gisvlasta.
// Updated by        : 09/01/2023, 20:56, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Georeferenceable_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_GridSpatialRepresentation_Type">
//       <xs:sequence>
//         <xs:element name="controlPointAvailability"
//                     type="gco:Boolean_PropertyType"/>
//         <xs:element name="orientationParameterAvailability"
//                     type="gco:Boolean_PropertyType"/>
//         <xs:element name="orientationParameterDescription"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="georeferencedParameters"
//                     type="gco:Record_PropertyType"/>
//         <xs:element name="parameterCitation"
//                     type="gmd:CI_Citation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Georeferenceable"
//             type="gmd:MD_Georeferenceable_Type" substitutionGroup="gmd:MD_GridSpatialRepresentation"/>
// <xs:complexType name="MD_Georeferenceable_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Georeferenceable"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Records;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  //[XmlInclude(typeof(MI_Georeferenceable_Type))]
  [Serializable]
  //[XmlType("MD_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Georeferenceable")]
  public class MD_Georeferenceable_Type : MD_GridSpatialRepresentation_Type {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georeferenceable_Type"/>.
    /// </summary>
    public MD_Georeferenceable_Type() {
      _controlPointAvailability = default; //  new Boolean_PropertyType();
      _orientationParameterAvailability = default; //  new Boolean_PropertyType();
      _orientationParameterDescription = default; //  new CharacterString();
      _georeferencedParameters = default; //  new Record_PropertyType();
      _parameterCitation = default; //  new List<CI_Citation_Type>();
    }

    #endregion

    #region Public Properties

    private bool _controlPointAvailability;

    /// <summary>
    /// Indication of whether or not control point(s) exists.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("controlPointAvailability", Order = 0)]
    [JsonProperty("controlPointAvailability", Order = 0)]
    public bool ControlPointAvailability {
      get => _controlPointAvailability;
      // TODO: SetProperty
      set {
        if (_controlPointAvailability == value) {
          return;
        }
        if (/*_controlPointAvailability == null || */_controlPointAvailability.Equals(value) != true) {
          _controlPointAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private bool _orientationParameterAvailability;

    /// <summary>
    /// Indication of whether or not orientation parameters are available.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("orientationParameterAvailability", Order = 1)]
    [JsonProperty("orientationParameterAvailability", Order = 1)]
    public bool OrientationParameterAvailability {
      get {
        return _orientationParameterAvailability;
      }
      // TODO: SetProperty
      set {
        if (_orientationParameterAvailability == value) {
          return;
        }
        if (/*_orientationParameterAvailability == null || */_orientationParameterAvailability.Equals(value) != true) {
          _orientationParameterAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString? _orientationParameterDescription;

    /// <summary>
    /// Description of parameters used to describe sensor orientation.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("orientationParameterDescription", Order = 2)]
    [JsonProperty("orientationParameterDescription", Order = 2)]
    public CharacterString? OrientationParameterDescription {
      get => _orientationParameterDescription;
      set => SetProperty(ref _orientationParameterDescription, value);
    }

    private Record_PropertyType _georeferencedParameters;

    /// <summary>
    /// Terms which support grid data georeferencing.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("georeferencedParameters", Order = 3)]
    [JsonProperty("georeferencedParameters", Order = 3)]
    public Record_PropertyType GeoreferencedParameters {
      get => _georeferencedParameters;
      set => SetProperty(ref _georeferencedParameters, value);
    }

    private List<CI_Citation_Type>? _parameterCitation;

    /// <summary>
    /// Reference providing description of the parameters.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("parameterCitation", Order = 4)]
    [JsonProperty("parameterCitation", Order = 4)]
    public List<CI_Citation_Type>? ParameterCitation {
      get => _parameterCitation;
      set => SetProperty(ref _parameterCitation, value);
    }

    #endregion

  }

}
