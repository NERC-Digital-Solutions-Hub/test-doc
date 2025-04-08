
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 04:03, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_UnitDefinition_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_UnitDefinition_PropertyType")]
  public class ML_UnitDefinition_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_UnitDefinition_PropertyType"/>.
    /// </summary>
    public ML_UnitDefinition_PropertyType() {
      _ml_UnitDefinition  = default; //  new ML_UnitDefinition_Type();
    }

    #endregion

    #region Public Properties

    private ML_UnitDefinition_Type _ml_UnitDefinition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_UnitDefinition", Order = 0)]
    [JsonProperty("ML_UnitDefinition", Order = 0)]
    public ML_UnitDefinition_Type ML_UnitDefinition {
      get {
        return _ml_UnitDefinition;
      }
      set {
        if (_ml_UnitDefinition == value) {
          return;
        }
        if (_ml_UnitDefinition == null || _ml_UnitDefinition.Equals(value) != true) {
          _ml_UnitDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
