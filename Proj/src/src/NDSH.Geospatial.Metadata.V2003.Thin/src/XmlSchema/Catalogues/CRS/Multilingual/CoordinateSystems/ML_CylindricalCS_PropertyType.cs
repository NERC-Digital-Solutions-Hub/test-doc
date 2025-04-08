
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 02:39, @gisvlasta.
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
  [XmlType("ML_CylindricalCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_CylindricalCS_PropertyType")]
  public class ML_CylindricalCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CylindricalCS_PropertyType"/>.
    /// </summary>
    public ML_CylindricalCS_PropertyType() {
      _ml_CylindricalCS  = default; //  new ML_CylindricalCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_CylindricalCS_Type _ml_CylindricalCS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_CylindricalCS", Order = 0)]
    [JsonProperty("ML_CylindricalCS", Order = 0)]
    public ML_CylindricalCS_Type ML_CylindricalCS {
      get {
        return _ml_CylindricalCS;
      }
      set {
        if (_ml_CylindricalCS == value) {
          return;
        }
        if (_ml_CylindricalCS == null || _ml_CylindricalCS.Equals(value) != true) {
          _ml_CylindricalCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
