
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
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Records;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Truth;
using NDSH.Geospatial.Metadata.V2003.Imagery.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.SpatialRepresentation {
  
  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(MI_Georeferenceable_Type))]
  [Serializable]
  [XmlType("MD_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Georeferenceable")]
  public class MD_Georeferenceable_Type : MD_GridSpatialRepresentation_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georeferenceable_Type"/>.
    /// </summary>
    public MD_Georeferenceable_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _controlPointAvailability  = default; //  new Boolean_PropertyType();
      _orientationParameterAvailability  = default; //  new Boolean_PropertyType();
      _orientationParameterDescription  = default; //  new CharacterString_PropertyType();
      _georeferencedParameters  = default; //  new Record_PropertyType();
      _parameterCitation  = default; //  new List<CI_Citation_PropertyType>();

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

    private Boolean_PropertyType _controlPointAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("controlPointAvailability", Order = 0)]
    [JsonProperty("controlPointAvailability", Order = 0)]
    public Boolean_PropertyType ControlPointAvailability {
      get {
        return _controlPointAvailability;
      }
      set {
        if (_controlPointAvailability == value) {
          return;
        }
        if (_controlPointAvailability == null || _controlPointAvailability.Equals(value) != true) {
          _controlPointAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _orientationParameterAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("orientationParameterAvailability", Order = 1)]
    [JsonProperty("orientationParameterAvailability", Order = 1)]
    public Boolean_PropertyType OrientationParameterAvailability {
      get {
        return _orientationParameterAvailability;
      }
      set {
        if (_orientationParameterAvailability == value) {
          return;
        }
        if (_orientationParameterAvailability == null || _orientationParameterAvailability.Equals(value) != true) {
          _orientationParameterAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _orientationParameterDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("orientationParameterDescription", Order = 2)]
    [JsonProperty("orientationParameterDescription", Order = 2)]
    public CharacterString_PropertyType OrientationParameterDescription {
      get {
        return _orientationParameterDescription;
      }
      set {
        if (_orientationParameterDescription == value) {
          return;
        }
        if (_orientationParameterDescription == null || _orientationParameterDescription.Equals(value) != true) {
          _orientationParameterDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private Record_PropertyType _georeferencedParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("georeferencedParameters", Order = 3)]
    [JsonProperty("georeferencedParameters", Order = 3)]
    public Record_PropertyType GeoreferencedParameters {
      get {
        return _georeferencedParameters;
      }
      set {
        if (_georeferencedParameters == value) {
          return;
        }
        if (_georeferencedParameters == null || _georeferencedParameters.Equals(value) != true) {
          _georeferencedParameters = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_Citation_PropertyType> _parameterCitation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parameterCitation", Order = 4)]
    [JsonProperty("parameterCitation", Order = 4)]
    public List<CI_Citation_PropertyType> ParameterCitation {
      get {
        return _parameterCitation;
      }
      set {
        if (_parameterCitation == value) {
          return;
        }
        if (_parameterCitation == null || _parameterCitation.Equals(value) != true) {
          _parameterCitation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
