
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 15:04, @EttoreM - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("MD_VectorSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_VectorSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_VectorSpatialRepresentation")]
  public class MD_VectorSpatialRepresentation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_VectorSpatialRepresentation"/>.
    /// </summary>
    public MD_VectorSpatialRepresentation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _topologyLevel = default;
      _geometricObjects = default;
      
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

    private MD_TopologyLevelCode _topologyLevel;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "topologyLevel")]
    [JsonProperty("topologyLevel", Order = 0)]
    public MD_TopologyLevelCode TopologyLevel {
      get {
        return _topologyLevel;
      }
      set {
        if (_topologyLevel == value) {
          return;
        }
        if (_topologyLevel == null || _topologyLevel.Equals(value) != true) {
          _topologyLevel = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_GeometricObjects> _geometricObjects;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geometricObjects", Order = 1, ElementName = "geometricObjects")]
    [JsonProperty("geometricObjects", Order = 1)]
    public List<MD_GeometricObjects> GeometricObjects {
      get {
        return _geometricObjects;
      }
      set {
        if (_geometricObjects == value) {
          return;
        }
        if (_geometricObjects == null || _geometricObjects.Equals(value) != true) {
          _geometricObjects = value;
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
