
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 01:55, @gisvlasta.
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
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_VerticalCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_VerticalCS_PropertyType")]
  public class ML_VerticalCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_VerticalCS_PropertyType"/>.
    /// </summary>
    public ML_VerticalCS_PropertyType() {
      _ml_VerticalCS  = default; //  new ML_VerticalCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_VerticalCS_Type _ml_VerticalCS;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_VerticalCS", Order = 0)]
    [JsonProperty("ML_VerticalCS", Order = 0)]
    public ML_VerticalCS_Type ML_VerticalCS {
      get {
        return _ml_VerticalCS;
      }
      set {
        if (_ml_VerticalCS == value) {
          return;
        }
        if (_ml_VerticalCS == null || _ml_VerticalCS.Equals(value) != true) {
          _ml_VerticalCS = value;
          OnPropertyChanged();
        }
      }
    }
    
    #endregion

  }

}
