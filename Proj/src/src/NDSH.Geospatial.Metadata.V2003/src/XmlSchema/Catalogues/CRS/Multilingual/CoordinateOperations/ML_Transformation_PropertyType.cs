
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 22:21, @gisvlasta.
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
  [XmlType("ML_Transformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_Transformation_PropertyType")]
  public class ML_Transformation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_Transformation_PropertyType"/>.
    /// </summary>
    public ML_Transformation_PropertyType() {
      _ml_Transformation  = default; //  new ML_Transformation_Type();
    }

    #endregion

    #region Public Properties
    
    private ML_Transformation_Type _ml_Transformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_Transformation", Order = 0)]
    [JsonProperty("ML_Transformation", Order = 0)]
    public ML_Transformation_Type ML_Transformation {
      get {
        return _ml_Transformation;
      }
      set {
        if (_ml_Transformation == value) {
          return;
        }
        if (_ml_Transformation == null || _ml_Transformation.Equals(value) != true) {
          _ml_Transformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
