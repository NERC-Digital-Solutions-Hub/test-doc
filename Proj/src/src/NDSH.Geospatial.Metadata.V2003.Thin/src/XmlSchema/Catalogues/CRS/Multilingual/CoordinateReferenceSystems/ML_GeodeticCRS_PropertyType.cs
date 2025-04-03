
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 23:40, @gisvlasta.
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
  [XmlType("ML_GeodeticCRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_GeodeticCRS_PropertyType")]
  public class ML_GeodeticCRS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_GeodeticCRS_PropertyType"/>.
    /// </summary>
    public ML_GeodeticCRS_PropertyType() {
      _ml_GeodeticCRS  = default; //  new ML_GeodeticCRS_Type();
    }

    #endregion

    #region Public Properties

    private ML_GeodeticCRS_Type _ml_GeodeticCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_GeodeticCRS", Order = 0)]
    [JsonProperty("ML_GeodeticCRS", Order = 0)]
    public ML_GeodeticCRS_Type ML_GeodeticCRS {
      get {
        return _ml_GeodeticCRS;
      }
      set {
        if (_ml_GeodeticCRS == value) {
          return;
        }
        if (_ml_GeodeticCRS == null || _ml_GeodeticCRS.Equals(value) != true) {
          _ml_GeodeticCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
