
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 14:49, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Nmaespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.SpatialSchema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

  /// <summary>
  /// Boundary enclosing the dataset expressed as the closed set of (x,y) coordinates of the polygon (last point replicates first point).
  /// </summary>
  [Serializable]
  [XmlType("EX_BoundingPolygon", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_BoundingPolygon", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_BoundingPolygon")]
  public class EX_BoundingPolygon_Type : AbstractEX_GeographicExtent_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_BoundingPolygon_Type"/>.
    /// </summary>
    public EX_BoundingPolygon_Type() {
      _polygon  = default; //  new List<GM_Object_PropertyType>();
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

    private List<GM_Object_PropertyType> _polygon;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("polygon", Order = 0)]
    [JsonProperty("polygon", Order = 0)]
    public List<GM_Object_PropertyType> Polygon {
      get {
        return _polygon;
      }
      set {
        if (_polygon == value) {
          return;
        }
        if (_polygon == null || _polygon.Equals(value) != true) {
          _polygon = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}