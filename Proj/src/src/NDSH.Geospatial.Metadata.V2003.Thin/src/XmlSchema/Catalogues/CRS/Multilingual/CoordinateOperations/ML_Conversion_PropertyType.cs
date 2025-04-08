
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 22:29, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_Conversion_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_Conversion_PropertyType")]
  public class ML_Conversion_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_Conversion_PropertyType"/>.
    /// </summary>
    public ML_Conversion_PropertyType() {
      _ml_Conversion  = default; //  new ML_Conversion_Type();
    }

    #endregion

    #region Public Properties

    private ML_Conversion_Type _ml_Conversion;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_Conversion", Order = 0)]
    [JsonProperty("ML_Conversion", Order = 0)]
    public ML_Conversion_Type ML_Conversion {
      get {
        return _ml_Conversion;
      }
      set {
        if (_ml_Conversion == value) {
          return;
        }
        if (_ml_Conversion == null || _ml_Conversion.Equals(value) != true) {
          _ml_Conversion = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
