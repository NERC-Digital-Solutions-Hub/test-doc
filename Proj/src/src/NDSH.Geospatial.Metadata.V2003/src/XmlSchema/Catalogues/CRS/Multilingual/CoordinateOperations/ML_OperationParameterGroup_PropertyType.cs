
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 10:46, @gisvlasta.
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
  [XmlType("ML_OperationParameterGroup_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_OperationParameterGroup_PropertyType")]
  public class ML_OperationParameterGroup_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_OperationParameterGroup_PropertyType"/> class constructor.
    /// </summary>
    public ML_OperationParameterGroup_PropertyType() {
      _ml_OperationParameterGroup  = default; //  new ML_OperationParameterGroup_Type();
    }

    #endregion

    #region Public Properties

    private ML_OperationParameterGroup_Type _ml_OperationParameterGroup;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_OperationParameterGroup", Order = 0)]
    [JsonProperty("ML_OperationParameterGroup", Order = 0)]
    public ML_OperationParameterGroup_Type ML_OperationParameterGroup {
      get {
        return _ml_OperationParameterGroup;
      }
      set {
        if (_ml_OperationParameterGroup == value) {
          return;
        }
        if (_ml_OperationParameterGroup == null || _ml_OperationParameterGroup.Equals(value) != true) {
          _ml_OperationParameterGroup = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
