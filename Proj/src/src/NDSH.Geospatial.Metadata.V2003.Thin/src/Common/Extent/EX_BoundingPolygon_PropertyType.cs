
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 19:51, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("EX_BoundingPolygon_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_BoundingPolygon_PropertyType")]
  public class EX_BoundingPolygon_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_BoundingPolygon_PropertyType"/>.
    /// </summary>
    public EX_BoundingPolygon_PropertyType() {
      _eX_BoundingPolygon  = default; //  new EX_BoundingPolygon_Type();
    }

    #endregion

    #region Public Properties

    private EX_BoundingPolygon_Type _eX_BoundingPolygon;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_BoundingPolygon", Order = 0)]
    [JsonProperty("EX_BoundingPolygon", Order = 0)]
    public EX_BoundingPolygon_Type EX_BoundingPolygon {
      get {
        return _eX_BoundingPolygon;
      }
      set {
        if (_eX_BoundingPolygon == value) {
          return;
        }
        if (_eX_BoundingPolygon == null || _eX_BoundingPolygon.Equals(value) != true) {
          _eX_BoundingPolygon = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}