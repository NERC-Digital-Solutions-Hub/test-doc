
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 16:24, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Application {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_Platform_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_Platform_PropertyType")]
  public class DS_Platform_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_Platform_PropertyType"/>.
    /// </summary>
    public DS_Platform_PropertyType() {
      _ds_Platform  = default; //  new DS_Platform_Type();
    }

    #endregion

    #region Public Properties

    private DS_Platform_Type _ds_Platform;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_Platform", Order = 0)]
    [JsonProperty("DS_Platform", Order = 0)]
    public DS_Platform_Type DS_Platform {
      get {
        return _ds_Platform;
      }
      set {
        if (_ds_Platform == value) {
          return;
        }
        if (_ds_Platform == null || _ds_Platform.Equals(value) != true) {
          _ds_Platform = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}