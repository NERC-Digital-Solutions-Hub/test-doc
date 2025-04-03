
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 00:25, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_TemporalCRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_TemporalCRS_PropertyType")]
  public class ML_TemporalCRS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_TemporalCRS_PropertyType"/>.
    /// </summary>
    public ML_TemporalCRS_PropertyType() {
      _ml_TemporalCRS  = default; //  new ML_TemporalCRS_Type();
    }

    #endregion

    #region Public Properties

    private ML_TemporalCRS_Type _ml_TemporalCRS;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_TemporalCRS", Order = 0)]
    [JsonProperty("ML_TemporalCRS", Order = 0)]
    public ML_TemporalCRS_Type ML_TemporalCRS {
      get {
        return _ml_TemporalCRS;
      }
      set {
        if (_ml_TemporalCRS == value) {
          return;
        }
        if (_ml_TemporalCRS == null || _ml_TemporalCRS.Equals(value) != true) {
          _ml_TemporalCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
