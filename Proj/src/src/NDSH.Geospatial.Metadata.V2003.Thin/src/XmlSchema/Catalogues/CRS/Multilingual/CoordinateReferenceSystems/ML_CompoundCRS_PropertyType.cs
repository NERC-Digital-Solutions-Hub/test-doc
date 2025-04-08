
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 23:31, @gisvlasta.
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
  [XmlType("ML_CompoundCRS_PropertyType" , Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_CompoundCRS_PropertyType")]
  public class ML_CompoundCRS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CompoundCRS_PropertyType"/>.
    /// </summary>
    public ML_CompoundCRS_PropertyType() {
      _ml_CompoundCRS  = default; //  new ML_CompoundCRS_Type();
    }

    #endregion

    #region Public Properties

    private ML_CompoundCRS_Type _ml_CompoundCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_CompoundCRS", Order = 0)]
    [JsonProperty("ML_CompoundCRS", Order = 0)]
    public ML_CompoundCRS_Type ML_CompoundCRS {
      get {
        return _ml_CompoundCRS;
      }
      set {
        if (_ml_CompoundCRS == value) {
          return;
        }
        if (_ml_CompoundCRS == null || _ml_CompoundCRS.Equals(value) != true) {
          _ml_CompoundCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
