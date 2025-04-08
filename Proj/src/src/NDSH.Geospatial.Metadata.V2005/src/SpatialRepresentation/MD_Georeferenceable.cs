
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 15:12, @EttoreM - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Records;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Georeferenceable")]
  public class MD_Georeferenceable : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georeferenceable"/>.
    /// </summary>
    public MD_Georeferenceable() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _numberOfDimensions = default;
      _axisDimensionProperties = default;
      _cellGeometry = default;
      _transformationParameterAvailability = default;
      _controlPointAvailability = default;
      _orientationParameterAvailability = default;
      _orientationParameterDescription = default;
      _georeferencedParameters = default;
      _parameterCitation = default;
      
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

    private int _numberOfDimensions;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "numberOfDimensions")]
    [RequiredAttribute()]
    [JsonProperty("numberOfDimensions", Order = 0)]
    public int NumberOfDimensions {
      get {
        return _numberOfDimensions;
      }
      set {
        if (_numberOfDimensions.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "NumberOfDimensions";
          Validator.ValidateProperty(value, validatorPropContext);
          _numberOfDimensions = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Dimension _axisDimensionProperties;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "axisDimensionProperties")]
    [JsonProperty("axisDimensionProperties", Order = 1)]
    public MD_Dimension AxisDimensionProperties {
      get {
        return _axisDimensionProperties;
      }
      set {
        if ((_axisDimensionProperties == value)) {
          return;
        }
        if (_axisDimensionProperties == null || _axisDimensionProperties.Equals(value) != true) {
          _axisDimensionProperties = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_CellGeometryCode _cellGeometry;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "cellGeometry")]
    [JsonProperty("cellGeometry", Order = 2)]
    public MD_CellGeometryCode CellGeometry {
      get {
        return _cellGeometry;
      }
      set {
        if ((_cellGeometry == value)) {
          return;
        }
        if (_cellGeometry == null || _cellGeometry.Equals(value) != true) {
          _cellGeometry = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _transformationParameterAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "transformationParameterAvailability")]
    [JsonProperty("transformationParameterAvailability", Order = 3)]
    public Boolean TransformationParameterAvailability {
      get {
        return _transformationParameterAvailability;
      }
      set {
        if (_transformationParameterAvailability == value) {
          return;
        }
        if (_transformationParameterAvailability == null || _transformationParameterAvailability.Equals(value) != true) {
          _transformationParameterAvailability = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _controlPointAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "controlPointAvailability")]
    [JsonProperty("controlPointAvailability", Order = 4)]
    public Boolean ControlPointAvailability {
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

    private Boolean _orientationParameterAvailability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "orientationParameterAvailability")]
    [JsonProperty("orientationParameterAvailability", Order = 5)]
    public Boolean OrientationParameterAvailability {
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

    private string _orientationParameterDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "orientationParameterDescription")]
    [JsonProperty("orientationParameterDescription", Order = 6)]
    public string OrientationParameterDescription {
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

    private Record _georeferencedParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7, ElementName = "georeferencedParameters")]
    [JsonProperty("georeferencedParameters", Order = 7)]
    public Record GeoreferencedParameters {
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

    private List<CI_Citation> _parameterCitation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parameterCitation", Order = 8, ElementName = "parameterCitation")]
    [JsonProperty("parameterCitation", Order = 8)]
    public List<CI_Citation> ParameterCitation {
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

    private string _id;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
