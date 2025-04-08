
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 02:22, @gisvlasta.
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
  [XmlType("ML_TimeCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_TimeCS_PropertyType")]
  public class ML_TimeCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_TimeCS_PropertyType"/>.
    /// </summary>
    public ML_TimeCS_PropertyType() {
      _ml_TimeCS  = default; //  new ML_TimeCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_TimeCS_Type _ml_TimeCS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_TimeCS", Order = 0)]
    [JsonProperty("ML_TimeCS", Order = 0)]
    public ML_TimeCS_Type ML_TimeCS {
      get {
        return _ml_TimeCS;
      }
      set {
        if (_ml_TimeCS == value) {
          return;
        }
        if (_ml_TimeCS == null || _ml_TimeCS.Equals(value) != true) {
          _ml_TimeCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
