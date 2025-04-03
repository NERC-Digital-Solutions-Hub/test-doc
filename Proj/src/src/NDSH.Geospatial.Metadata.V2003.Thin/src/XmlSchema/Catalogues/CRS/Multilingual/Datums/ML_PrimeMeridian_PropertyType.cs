
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 14:21, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_PrimeMeridian_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_PrimeMeridian_PropertyType")]
  public class ML_PrimeMeridian_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_PrimeMeridian_PropertyType"/>.
    /// </summary>
    public ML_PrimeMeridian_PropertyType() {
      _ml_PrimeMeridian  = default; //  new ML_PrimeMeridian_Type();
    }

    #endregion

    #region Public Properties

    private ML_PrimeMeridian_Type _ml_PrimeMeridian;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_PrimeMeridian", Order = 0)]
    [JsonProperty("ML_PrimeMeridian", Order = 0)]
    public ML_PrimeMeridian_Type ML_PrimeMeridian {
      get {
        return _ml_PrimeMeridian;
      }
      set {
        if (_ml_PrimeMeridian == value) {
          return;
        }
        if (_ml_PrimeMeridian == null || _ml_PrimeMeridian.Equals(value) != true) {
          _ml_PrimeMeridian = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }


}
