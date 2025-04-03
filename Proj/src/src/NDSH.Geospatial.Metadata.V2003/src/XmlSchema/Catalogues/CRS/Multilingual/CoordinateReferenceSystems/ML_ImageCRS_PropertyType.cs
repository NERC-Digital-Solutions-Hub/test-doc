
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 00:32, @gisvlasta.
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
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_ImageCRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_ImageCRS_PropertyType")]
  public class ML_ImageCRS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_ImageCRS_PropertyType"/>.
    /// </summary>
    public ML_ImageCRS_PropertyType() {
      _ml_ImageCRS  = default; //  new ML_ImageCRS_Type();
    }

    #endregion

    #region Public Properties

    private ML_ImageCRS_Type _ml_ImageCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_ImageCRS", Order = 0)]
    [JsonProperty("ML_ImageCRS", Order = 0)]
    public ML_ImageCRS_Type ML_ImageCRS {
      get {
        return _ml_ImageCRS;
      }
      set {
        if (_ml_ImageCRS == value) {
          return;
        }
        if (_ml_ImageCRS == null || _ml_ImageCRS.Equals(value) != true) {
          _ml_ImageCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
