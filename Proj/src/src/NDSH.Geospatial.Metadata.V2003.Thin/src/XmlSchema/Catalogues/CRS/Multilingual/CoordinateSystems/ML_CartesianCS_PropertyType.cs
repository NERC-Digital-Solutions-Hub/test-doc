
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 01:26, @gisvlasta.
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
  [XmlType("ML_CartesianCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_CartesianCS_PropertyType")]
  public class ML_CartesianCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CartesianCS_PropertyType"/>.
    /// </summary>
    public ML_CartesianCS_PropertyType() {
      _ml_CartesianCS  = default; //  new ML_CartesianCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_CartesianCS_Type _ml_CartesianCS;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_CartesianCS", Order = 0)]
    [JsonProperty("ML_CartesianCS", Order = 0)]
    public ML_CartesianCS_Type ML_CartesianCS {
      get {
        return _ml_CartesianCS;
      }
      set {
        if (_ml_CartesianCS == value) {
          return;
        }
        if (_ml_CartesianCS == null || _ml_CartesianCS.Equals(value) != true) {
          _ml_CartesianCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
