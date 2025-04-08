
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 03:46, @gisvlasta.
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
  [XmlType("ML_DerivedUnit_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_DerivedUnit_PropertyType")]
  public class ML_DerivedUnit_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_DerivedUnit_PropertyType"/>.
    /// </summary>
    public ML_DerivedUnit_PropertyType() {
      _ml_DerivedUnit  = default; //  new ML_DerivedUnit_Type();
    }

    #endregion

    #region Public Properties

    private ML_DerivedUnit_Type _ml_DerivedUnit;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_DerivedUnit", Order = 0)]
    [JsonProperty("ML_DerivedUnit", Order = 0)]
    public ML_DerivedUnit_Type ML_DerivedUnit {
      get {
        return _ml_DerivedUnit;
      }
      set {
        if (_ml_DerivedUnit == value) {
          return;
        }
        if (_ml_DerivedUnit == null || _ml_DerivedUnit.Equals(value) != true) {
          _ml_DerivedUnit = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
