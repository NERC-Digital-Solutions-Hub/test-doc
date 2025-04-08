
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:30, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Georectified_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Georectified_PropertyType")]
  public class MI_Georectified_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Georectified_PropertyType"/>.
    /// </summary>
    public MI_Georectified_PropertyType() {
      _mi_Georectified = default; // new MI_Georectified_Type();
    }

    #endregion

    #region Public Properties

    private MI_Georectified_Type _mi_Georectified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Georectified", Order = 0)]
    [JsonProperty("MI_Georectified", Order = 0)]
    public MI_Georectified_Type MI_Georectified {
      get {
        return _mi_Georectified;
      }
      set {
        if (_mi_Georectified == value) {
          return;
        }
        if (_mi_Georectified == null || _mi_Georectified.Equals(value) != true) {
          _mi_Georectified = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
