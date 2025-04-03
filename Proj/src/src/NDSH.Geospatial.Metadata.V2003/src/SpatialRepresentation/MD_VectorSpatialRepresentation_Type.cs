
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:03, @gisvlasta.
// Updated by        : 09/01/2023, 20:55, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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
  /// Information about the vector spatial objects in the dataset.
  /// </summary>
  [Serializable]
  [XmlType("MD_VectorSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_VectorSpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_VectorSpatialRepresentation")]
  public class MD_VectorSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_VectorSpatialRepresentation_Type"/>.
    /// </summary>
    public MD_VectorSpatialRepresentation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _topologyLevel  = default; //  new MD_TopologyLevelCode_PropertyType();
      _geometricObjects  = default; //  new List<MD_GeometricObjects_PropertyType>();

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

    private MD_TopologyLevelCode_PropertyType _topologyLevel;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("topologyLevel", Order = 0)]
    [JsonProperty("topologyLevel", Order = 0)]
    public MD_TopologyLevelCode_PropertyType TopologyLevel {
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

    private List<MD_GeometricObjects_PropertyType> _geometricObjects;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geometricObjects", Order = 1)]
    [JsonProperty("geometricObjects", Order = 1)]
    public List<MD_GeometricObjects_PropertyType> GeometricObjects {
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

    #endregion

  }

}
