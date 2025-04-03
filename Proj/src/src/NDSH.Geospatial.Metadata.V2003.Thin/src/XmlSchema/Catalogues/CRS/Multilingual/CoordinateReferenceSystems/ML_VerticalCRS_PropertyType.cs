
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 00:01, @gisvlasta.
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
  [XmlType("ML_VerticalCRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_VerticalCRS_PropertyType")]
  public class ML_VerticalCRS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_VerticalCRS_PropertyType"/>.
    /// </summary>
    public ML_VerticalCRS_PropertyType() {
      _ml_VerticalCRS  = default; //  new ML_VerticalCRS_Type();
    }

    #endregion

    #region Public Properties

    private ML_VerticalCRS_Type _ml_VerticalCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_VerticalCRS", Order = 0)]
    [JsonProperty("ML_VerticalCRS", Order = 0)]
    public ML_VerticalCRS_Type ML_VerticalCRS {
      get {
        return _ml_VerticalCRS;
      }
      set {
        if (_ml_VerticalCRS == value) {
          return;
        }
        if (_ml_VerticalCRS == null || _ml_VerticalCRS.Equals(value) != true) {
          _ml_VerticalCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
