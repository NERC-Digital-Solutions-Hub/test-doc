
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 02:48, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_SphericalCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_SphericalCS_PropertyType")]
  public class ML_SphericalCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_SphericalCS_PropertyType"/>.
    /// </summary>
    public ML_SphericalCS_PropertyType() {
      _ml_SphericalCS  = default; //  new ML_SphericalCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_SphericalCS_Type _ml_SphericalCS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_SphericalCS", Order = 0)]
    [JsonProperty("ML_SphericalCS", Order = 0)]
    public ML_SphericalCS_Type ML_SphericalCS {
      get {
        return _ml_SphericalCS;
      }
      set {
        if (_ml_SphericalCS == value) {
          return;
        }
        if (_ml_SphericalCS == null || _ml_SphericalCS.Equals(value) != true) {
          _ml_SphericalCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
