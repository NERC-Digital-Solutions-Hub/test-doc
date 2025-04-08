
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 15:17, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_GeodeticDatum_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_GeodeticDatum_PropertyType")]
  public class ML_GeodeticDatum_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_GeodeticDatum_PropertyType"/>.
    /// </summary>
    public ML_GeodeticDatum_PropertyType() {
      _ml_GeodeticDatum  = default; //  new ML_GeodeticDatum_Type();
    }

    #endregion

    #region Public Properties

    private ML_GeodeticDatum_Type _ml_GeodeticDatum;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_GeodeticDatum", Order = 0)]
    [JsonProperty("ML_GeodeticDatum", Order = 0)]
    public ML_GeodeticDatum_Type ML_GeodeticDatum {
      get {
        return _ml_GeodeticDatum;
      }
      set {
        if (_ml_GeodeticDatum == value) {
          return;
        }
        if (_ml_GeodeticDatum == null || _ml_GeodeticDatum.Equals(value) != true) {
          _ml_GeodeticDatum = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
