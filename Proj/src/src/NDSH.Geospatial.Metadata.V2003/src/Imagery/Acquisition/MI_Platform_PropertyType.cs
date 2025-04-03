
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:44, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Platform_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Platform_PropertyType")]
  public class MI_Platform_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Platform_PropertyType"/>.
    /// </summary>
    public MI_Platform_PropertyType() {
      _mi_Platform = default; // new MI_Platform_Type();
    }

    #endregion

    #region Public Properties

    private MI_Platform_Type _mi_Platform;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Platform", Order = 0)]
    [JsonProperty("MI_Platform", Order = 0)]
    public MI_Platform_Type MI_Platform {
      get {
        return _mi_Platform;
      }
      set {
        if (_mi_Platform == value) {
          return;
        }
        if (_mi_Platform == null || _mi_Platform.Equals(value) != true) {
          _mi_Platform = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
