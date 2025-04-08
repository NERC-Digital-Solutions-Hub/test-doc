
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 10:31, @gisvlasta.
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
  [XmlType("ML_OperationMethod_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_OperationMethod_PropertyType")]
  public class ML_OperationMethod_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_OperationMethod_PropertyType"/>.
    /// </summary>
    public ML_OperationMethod_PropertyType() {
      _ml_OperationMethod  = default; //  new ML_OperationMethod_Type();
    }

    #endregion

    #region Public Proeprties

    private ML_OperationMethod_Type _ml_OperationMethod;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_OperationMethod", Order = 0)]
    [JsonProperty("ML_OperationMethod", Order = 0)]
    public ML_OperationMethod_Type ML_OperationMethod {
      get {
        return _ml_OperationMethod;
      }
      set {
        if (_ml_OperationMethod == value) {
          return;
        }
        if (_ml_OperationMethod == null || _ml_OperationMethod.Equals(value) != true) {
          _ml_OperationMethod = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
