
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 11:37, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CoordinateSystemAxisAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CoordinateSystemAxisAlt_PropertyType")]
  public class CoordinateSystemAxisAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CoordinateSystemAxisAlt_PropertyType"/>.
    /// </summary>
    public CoordinateSystemAxisAlt_PropertyType() {
      _coordinateSystemAxisAlt  = default; //  new CoordinateSystemAxisAlt_Type();
    }

    #endregion

    #region Public Properties

    private CoordinateSystemAxisAlt_Type _coordinateSystemAxisAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CoordinateSystemAxisAlt", Order = 0)]
    [JsonProperty("CoordinateSystemAxisAlt", Order = 0)]
    public CoordinateSystemAxisAlt_Type CoordinateSystemAxisAlt {
      get {
        return _coordinateSystemAxisAlt;
      }
      set {
        if (_coordinateSystemAxisAlt == value) {
          return;
        }
        if (_coordinateSystemAxisAlt == null || _coordinateSystemAxisAlt.Equals(value) != true) {
          _coordinateSystemAxisAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
