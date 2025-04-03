
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 01:16, @gisvlasta.
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
  [XmlType("ML_EllipsoidalCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_EllipsoidalCS_PropertyType")]
  public class ML_EllipsoidalCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_EllipsoidalCS_PropertyType"/>.
    /// </summary>
    public ML_EllipsoidalCS_PropertyType() {
      _ml_EllipsoidalCS  = default; //  new ML_EllipsoidalCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_EllipsoidalCS_Type _ml_EllipsoidalCS;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_EllipsoidalCS", Order = 0)]
    [JsonProperty("ML_EllipsoidalCS", Order = 0)]
    public ML_EllipsoidalCS_Type ML_EllipsoidalCS {
      get {
        return _ml_EllipsoidalCS;
      }
      set {
        if (_ml_EllipsoidalCS == value) {
          return;
        }
        if (_ml_EllipsoidalCS == null || _ml_EllipsoidalCS.Equals(value) != true) {
          _ml_EllipsoidalCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
