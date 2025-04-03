
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 03:22, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_Ellipsoid_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_Ellipsoid_PropertyType")]
  public class ML_Ellipsoid_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_Ellipsoid_PropertyType"/>.
    /// </summary>
    public ML_Ellipsoid_PropertyType() {
      _ml_Ellipsoid  = default; //  new ML_Ellipsoid_Type();
    }

    #endregion

    #region Public Properties

    private ML_Ellipsoid_Type _ml_Ellipsoid;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_Ellipsoid", Order = 0)]
    [JsonProperty("ML_Ellipsoid", Order = 0 )]
    public ML_Ellipsoid_Type ML_Ellipsoid {
      get {
        return _ml_Ellipsoid;
      }
      set {
        if (_ml_Ellipsoid == value) {
          return;
        }
        if (_ml_Ellipsoid == null || _ml_Ellipsoid.Equals(value) != true) {
          _ml_Ellipsoid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
