
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 03:08, @gisvlasta.
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
  [XmlType("ML_LinearCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_LinearCS_PropertyType")]
  public class ML_LinearCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_LinearCS_PropertyType"/>.
    /// </summary>
    public ML_LinearCS_PropertyType() {
      _ml_LinearCS  = default; //  new ML_LinearCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_LinearCS_Type _ml_LinearCS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_LinearCS", Order = 0)]
    [JsonProperty("ML_LinearCS", Order = 0)]
    public ML_LinearCS_Type ML_LinearCS {
      get {
        return _ml_LinearCS;
      }
      set {
        if (_ml_LinearCS == value) {
          return;
        }
        if (_ml_LinearCS == null || _ml_LinearCS.Equals(value) != true) {
          _ml_LinearCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
