
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:22, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums;
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_Ellipsoid_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_Ellipsoid_PropertyType")]
  public class CT_Ellipsoid_PropertyType : ObjectReference_PropertyType {

    #region Cosntructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_Ellipsoid_PropertyType"/>.
    /// </summary>
    public CT_Ellipsoid_PropertyType() {
      _ellipsoid = default; //  new EllipsoidType();
    }

    #endregion

    #region Public Properties

    private EllipsoidType _ellipsoid;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Ellipsoid", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("Ellipsoid", Order = 0)]
    public EllipsoidType Ellipsoid {
      get {
        return _ellipsoid;
      }
      set {
        if (_ellipsoid == value) {
          return;
        }
        if (_ellipsoid == null || _ellipsoid.Equals(value) != true) {
          _ellipsoid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
