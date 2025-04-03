
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 05:03, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.SpatialSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("GM_Object_PropertyType", Namespace = "http://www.isotc211.org/2005/gss")]
  [JsonObject("GM_Object_PropertyType")]
  public class GM_Object_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractGeometryType _abstractGeometry;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractGeometry", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractGeometry", Order = 0)]
    public AbstractGeometryType AbstractGeometry {
      get {
        return _abstractGeometry;
      }
      set {
        if (_abstractGeometry == value) {
          return;
        }
        if (_abstractGeometry == null || _abstractGeometry.Equals(value) != true) {
          _abstractGeometry = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
