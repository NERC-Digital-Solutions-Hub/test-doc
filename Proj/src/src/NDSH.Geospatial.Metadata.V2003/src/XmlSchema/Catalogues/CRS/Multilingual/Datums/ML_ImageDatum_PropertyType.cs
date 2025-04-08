
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 15:00, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.Datums {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_ImageDatum_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_ImageDatum_PropertyType")]
  public class ML_ImageDatum_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_ImageDatum_PropertyType"/>.
    /// </summary>
    public ML_ImageDatum_PropertyType() {
      _ml_ImageDatum  = default; //  new ML_ImageDatum_Type();
    }

    #endregion

    #region Public Properties

    private ML_ImageDatum_Type _ml_ImageDatum;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_ImageDatum", Order = 0)]
    [JsonProperty("ML_ImageDatum", Order = 0)]
    public ML_ImageDatum_Type ML_ImageDatum {
      get {
        return _ml_ImageDatum;
      }
      set {
        if (_ml_ImageDatum == value) {
          return;
        }
        if (_ml_ImageDatum == null || _ml_ImageDatum.Equals(value) != true) {
          _ml_ImageDatum = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
