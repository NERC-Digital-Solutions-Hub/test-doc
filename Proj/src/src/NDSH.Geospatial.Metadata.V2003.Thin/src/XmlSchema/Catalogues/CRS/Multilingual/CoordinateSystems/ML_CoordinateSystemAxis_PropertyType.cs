
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 01:06, @gisvlasta.
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
  [XmlType("ML_CoordinateSystemAxis_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_CoordinateSystemAxis_PropertyType")]
  public class ML_CoordinateSystemAxis_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CoordinateSystemAxis_PropertyType"/>
    /// </summary>
    public ML_CoordinateSystemAxis_PropertyType() {
      _ml_CoordinateSystemAxis  = default; //  new ML_CoordinateSystemAxis_Type();
    }

    #endregion

    #region Public Properties

    private ML_CoordinateSystemAxis_Type _ml_CoordinateSystemAxis;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_CoordinateSystemAxis", Order = 0)]
    [JsonProperty("ML_CoordinateSystemAxis", Order = 0)]
    public ML_CoordinateSystemAxis_Type ML_CoordinateSystemAxis {
      get {
        return _ml_CoordinateSystemAxis;
      }
      set {
        if (_ml_CoordinateSystemAxis == value) {
          return;
        }
        if (_ml_CoordinateSystemAxis == null || _ml_CoordinateSystemAxis.Equals(value) != true) {
          _ml_CoordinateSystemAxis = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
