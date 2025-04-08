
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 11:18, @gisvlasta.
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
  [XmlType("CoordinateSystemAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CoordinateSystemAlt_PropertyType")]
  public class CoordinateSystemAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CoordinateSystemAlt_PropertyType"/>.
    /// </summary>
    public CoordinateSystemAlt_PropertyType() {
      _coordinateSystemAlt  = default; //  new CoordinateSystemAlt_Type();
    }

    #endregion

    #region Public Properties

    private CoordinateSystemAlt_Type _coordinateSystemAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CoordinateSystemAlt", Order = 0)]
    [JsonProperty("CoordinateSystemAlt", Order = 0)]
    public CoordinateSystemAlt_Type CoordinateSystemAlt {
      get {
        return _coordinateSystemAlt;
      }
      set {
        if (_coordinateSystemAlt == value) {
          return;
        }
        if (_coordinateSystemAlt == null || _coordinateSystemAlt.Equals(value) != true) {
          _coordinateSystemAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
