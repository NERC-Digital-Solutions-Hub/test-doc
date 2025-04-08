
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 01:35, @gisvlasta.
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
  [XmlType("ML_AffineCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_AffineCS_PropertyType")]
  public class ML_AffineCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_AffineCS_PropertyType"/>.
    /// </summary>
    public ML_AffineCS_PropertyType() {
      _ml_AffineCS  = default; //  new ML_AffineCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_AffineCS_Type _ml_AffineCS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_AffineCS", Order = 0)]
    [JsonProperty("ML_AffineCS", Order = 0)]
    public ML_AffineCS_Type ML_AffineCS {
      get {
        return _ml_AffineCS;
      }
      set {
        if (_ml_AffineCS == value) {
          return;
        }
        if (_ml_AffineCS == null || _ml_AffineCS.Equals(value) != true) {
          _ml_AffineCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
