
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 18:45, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_Association_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_Association_PropertyType")]
  public class DS_Association_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_Association_PropertyType"/>.
    /// </summary>
    public DS_Association_PropertyType() {
      _ds_Association  = default; //  new DS_Association_Type();
    }

    #endregion

    #region Public Proeprties

    private DS_Association_Type _ds_Association;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_Association", Order = 0)]
    [JsonProperty("DS_Association", Order = 0)]
    public DS_Association_Type DS_Association {
      get {
        return _ds_Association;
      }
      set {
        if (_ds_Association == value) {
          return;
        }
        if (_ds_Association == null || _ds_Association.Equals(value) != true) {
          _ds_Association = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
