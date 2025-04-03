
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : dd/mm/2022, hh:MM, @gisvlasta.
// Updated by        : 16/12/2022, 15:09, @EttoreM - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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
  [XmlRoot("MD_GridSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_GridSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_GridSpatialRepresentation")]
  public class MD_GridSpatialRepresentation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GridSpatialRepresentation"/>.
    /// </summary>
    public MD_GridSpatialRepresentation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _numberOfDimensions = default;
      _axisDimensionProperties = default;
      _cellGeometry = default;
      _transformationParameterAvailability = default;
     
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
        if (_axisDimensionProperties == value) {
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
        if (_cellGeometry == value) {
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
