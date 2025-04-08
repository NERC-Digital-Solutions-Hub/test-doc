
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 03:00, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_PolarCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_PolarCS_PropertyType")]
  public class ML_PolarCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_PolarCS_PropertyType"/>.
    /// </summary>
    public ML_PolarCS_PropertyType() {
      _ml_PolarCS  = default; //  new ML_PolarCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_PolarCS_Type _ml_PolarCS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_PolarCS", Order = 0)]
    [JsonProperty("ML_PolarCS", Order = 0)]
    public ML_PolarCS_Type ML_PolarCS {
      get {
        return _ml_PolarCS;
      }
      set {
        if (_ml_PolarCS == value) {
          return;
        }
        if (_ml_PolarCS == null || _ml_PolarCS.Equals(value) != true) {
          _ml_PolarCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
