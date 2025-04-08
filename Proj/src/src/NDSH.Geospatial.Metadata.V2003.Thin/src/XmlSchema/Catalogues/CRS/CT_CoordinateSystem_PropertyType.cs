
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:33, @gisvlasta.
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
  [XmlType("CT_CoordinateSystem_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_CoordinateSystem_PropertyType")]
  public class CT_CoordinateSystem_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractCoordinateSystemType _abstractCoordinateSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractCoordinateSystem", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractCoordinateSystem", Order = 0)]
    public AbstractCoordinateSystemType AbstractCoordinateSystem {
      get {
        return _abstractCoordinateSystem;
      }
      set {
        if (_abstractCoordinateSystem == value) {
          return;
        }
        if (_abstractCoordinateSystem == null || _abstractCoordinateSystem.Equals(value) != true) {
          _abstractCoordinateSystem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
