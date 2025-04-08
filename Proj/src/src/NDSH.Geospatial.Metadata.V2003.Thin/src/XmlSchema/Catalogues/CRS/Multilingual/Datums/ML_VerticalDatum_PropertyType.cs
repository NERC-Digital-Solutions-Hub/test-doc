
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 14:48, @gisvlasta.
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
  [XmlType("ML_VerticalDatum_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_VerticalDatum_PropertyType")]
  public class ML_VerticalDatum_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_VerticalDatum_PropertyType"/>.
    /// </summary>
    public ML_VerticalDatum_PropertyType() {
      _ml_VerticalDatum  = default; //  new ML_VerticalDatum_Type();
    }

    #endregion

    #region Public Properties

    private ML_VerticalDatum_Type _ml_VerticalDatum;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_VerticalDatum", Order = 0)]
    [JsonProperty("ML_VerticalDatum", Order = 0)]
    public ML_VerticalDatum_Type ML_VerticalDatum {
      get {
        return _ml_VerticalDatum;
      }
      set {
        if (_ml_VerticalDatum == value) {
          return;
        }
        if (_ml_VerticalDatum == null || _ml_VerticalDatum.Equals(value) != true) {
          _ml_VerticalDatum = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
