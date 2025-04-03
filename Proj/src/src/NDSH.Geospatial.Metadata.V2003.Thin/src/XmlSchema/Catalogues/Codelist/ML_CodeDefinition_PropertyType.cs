
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 16:58, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_CodeDefinition_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_CodeDefinition_PropertyType")]
  public class ML_CodeDefinition_PropertyType : ObjectReference_PropertyType {

    #region Imported Namespaces

    /// <summary>
    /// Initializes the <see cref="ML_CodeDefinition_PropertyType"/>.
    /// </summary>
    public ML_CodeDefinition_PropertyType() {
      _ml_CodeDefinition  = default; //  new ML_CodeDefinition_Type();
    }

    #endregion

    #region Public Properties

    private ML_CodeDefinition_Type _ml_CodeDefinition;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_CodeDefinition", Order = 0)]
    [JsonProperty("ML_CodeDefinition", Order = 0)]
    public ML_CodeDefinition_Type ML_CodeDefinition {
      get {
        return _ml_CodeDefinition;
      }
      set {
        if (_ml_CodeDefinition == value) {
          return;
        }
        if (_ml_CodeDefinition == null || _ml_CodeDefinition.Equals(value) != true) {
          _ml_CodeDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
