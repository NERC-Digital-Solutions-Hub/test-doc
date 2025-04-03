
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 00:50, @gisvlasta.
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
  [XmlType("ML_ProjectedCRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_ProjectedCRS_PropertyType")]
  public class ML_ProjectedCRS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_ProjectedCRS_PropertyType"/>.
    /// </summary>
    public ML_ProjectedCRS_PropertyType() {
      _ml_ProjectedCRS  = default; //  new ML_ProjectedCRS_Type();
    }

    #endregion

    #region Public Properties

    private ML_ProjectedCRS_Type _ml_ProjectedCRS;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_ProjectedCRS", Order = 0)]
    [JsonProperty("ML_ProjectedCRS", Order = 0)]
    public ML_ProjectedCRS_Type ML_ProjectedCRS {
      get {
        return _ml_ProjectedCRS;
      }
      set {
        if (_ml_ProjectedCRS == value) {
          return;
        }
        if (_ml_ProjectedCRS == null || _ml_ProjectedCRS.Equals(value) != true) {
          _ml_ProjectedCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
