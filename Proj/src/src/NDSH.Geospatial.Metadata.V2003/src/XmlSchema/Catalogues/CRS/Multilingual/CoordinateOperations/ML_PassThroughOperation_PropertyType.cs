
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 21:58, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_PassThroughOperation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_PassThroughOperation_PropertyType")]
  public class ML_PassThroughOperation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_PassThroughOperation_PropertyType"/>.
    /// </summary>
    public ML_PassThroughOperation_PropertyType() {
      _ml_PassThroughOperation  = default; //  new ML_PassThroughOperation_Type();
    }

    #endregion

    #region Public Properties

    private ML_PassThroughOperation_Type _ml_PassThroughOperation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_PassThroughOperation", Order = 0)]
    [JsonProperty("ML_PassThroughOperation", Order = 0)]
    public ML_PassThroughOperation_Type ML_PassThroughOperation {
      get {
        return _ml_PassThroughOperation;
      }
      set {
        if (_ml_PassThroughOperation == value) {
          return;
        }
        if (_ml_PassThroughOperation == null || _ml_PassThroughOperation.Equals(value) != true) {
          _ml_PassThroughOperation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
