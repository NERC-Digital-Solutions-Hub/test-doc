
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 01:46, @gisvlasta.
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
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_UserDefinedCS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_UserDefinedCS_PropertyType")]
  public class ML_UserDefinedCS_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_UserDefinedCS_PropertyType"/>.
    /// </summary>
    public ML_UserDefinedCS_PropertyType() {
      _ml_UserDefinedCS  = default; //  new ML_UserDefinedCS_Type();
    }

    #endregion

    #region Public Properties

    private ML_UserDefinedCS_Type _ml_UserDefinedCS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_UserDefinedCS", Order = 0)]
    [JsonProperty("ML_UserDefinedCS", Order = 0)]
    public ML_UserDefinedCS_Type ML_UserDefinedCS {
      get {
        return _ml_UserDefinedCS;
      }
      set {
        if (_ml_UserDefinedCS == value) {
          return;
        }
        if (_ml_UserDefinedCS == null || _ml_UserDefinedCS.Equals(value) != true) {
          _ml_UserDefinedCS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
