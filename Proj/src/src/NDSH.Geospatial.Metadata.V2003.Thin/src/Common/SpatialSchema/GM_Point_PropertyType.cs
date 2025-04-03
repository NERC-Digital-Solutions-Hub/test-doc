
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 05:06, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.SpatialSchema
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("GM_Point_PropertyType", Namespace = "http://www.isotc211.org/2005/gss")]
  [JsonObject("GM_Point_PropertyType")]
  public class GM_Point_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GM_Point_PropertyType"/>.
    /// </summary>
    public GM_Point_PropertyType() {
      _point  = default; //  new PointType();
    }

    #endregion

    #region Public Properties

    private PointType _point;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Point", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("Point", Order = 0)]
    public PointType Point {
      get {
        return _point;
      }
      set {
        if (_point == value) {
          return;
        }
        if (_point == null || _point.Equals(value) != true) {
          _point = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}