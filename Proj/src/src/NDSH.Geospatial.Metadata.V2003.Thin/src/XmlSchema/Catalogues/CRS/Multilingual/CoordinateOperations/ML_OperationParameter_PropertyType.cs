
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 10:55, @gisvlasta.
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
  [XmlType("ML_OperationParameter_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_OperationParameter_PropertyType")]
  public class ML_OperationParameter_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_OperationParameter_PropertyType"/>.
    /// </summary>
    public ML_OperationParameter_PropertyType() {
      _ml_OperationParameter  = default; //  new ML_OperationParameter_Type();
    }

    #endregion

    #region Public Properties

    private ML_OperationParameter_Type _ml_OperationParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_OperationParameter", Order = 0)]
    [JsonProperty("ML_OperationParameter", Order = 0)]
    public ML_OperationParameter_Type ML_OperationParameter {
      get {
        return _ml_OperationParameter;
      }
      set {
        if (_ml_OperationParameter == value) {
          return;
        }
        if (_ml_OperationParameter == null || _ml_OperationParameter.Equals(value) != true) {
          _ml_OperationParameter = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
