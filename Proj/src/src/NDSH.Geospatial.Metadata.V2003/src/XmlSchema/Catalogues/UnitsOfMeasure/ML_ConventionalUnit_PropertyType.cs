
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 03:54, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_ConventionalUnit_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_ConventionalUnit_PropertyType")]
  public class ML_ConventionalUnit_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_ConventionalUnit_PropertyType"/>.
    /// </summary>
    public ML_ConventionalUnit_PropertyType() {
      _ml_ConventionalUnit  = default; //  new ML_ConventionalUnit_Type();
    }

    #endregion

    #region Public Properties

    private ML_ConventionalUnit_Type _ml_ConventionalUnit;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_ConventionalUnit", Order = 0)]
    [JsonProperty("ML_ConventionalUnit", Order = 0)]
    public ML_ConventionalUnit_Type ML_ConventionalUnit {
      get {
        return _ml_ConventionalUnit;
      }
      set {
        if (_ml_ConventionalUnit == value) {
          return;
        }
        if (_ml_ConventionalUnit == null || _ml_ConventionalUnit.Equals(value) != true) {
          _ml_ConventionalUnit = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
