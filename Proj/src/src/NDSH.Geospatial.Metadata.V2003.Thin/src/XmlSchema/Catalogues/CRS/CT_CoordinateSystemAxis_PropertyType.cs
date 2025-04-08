
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:30, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.GML;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_CoordinateSystemAxis_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_CoordinateSystemAxis_PropertyType")]
  public class CT_CoordinateSystemAxis_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CoordinateSystemAxis_PropertyType"/>.
    /// </summary>
    public CT_CoordinateSystemAxis_PropertyType() {
      _coordinateSystemAxis  = default; //  new CoordinateSystemAxisType();
    }

    #endregion

    #region Public Properties

    private CoordinateSystemAxisType _coordinateSystemAxis;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CoordinateSystemAxis", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("CoordinateSystemAxis", Order = 0)]
    public CoordinateSystemAxisType CoordinateSystemAxis {
      get {
        return _coordinateSystemAxis;
      }
      set {
        if (_coordinateSystemAxis == value) {
          return;
        }
        if (_coordinateSystemAxis == null || _coordinateSystemAxis.Equals(value) != true) {
          _coordinateSystemAxis = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
