
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 00:57, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_DerivedCRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_DerivedCRS_PropertyType")]
  public class ML_DerivedCRS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_DerivedCRS_PropertyType"/>.
    /// </summary>
    public ML_DerivedCRS_PropertyType() {
      _ml_DerivedCRS  = default; //  new ML_DerivedCRS_Type();
    }

    #endregion

    #region Public Properties

    private ML_DerivedCRS_Type _ml_DerivedCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_DerivedCRS", Order = 0)]
    [JsonProperty("ML_DerivedCRS", Order = 0)]
    public ML_DerivedCRS_Type ML_DerivedCRS {
      get {
        return _ml_DerivedCRS;
      }
      set {
        if (_ml_DerivedCRS == value) {
          return;
        }
        if (_ml_DerivedCRS == null || _ml_DerivedCRS.Equals(value) != true) {
          _ml_DerivedCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
