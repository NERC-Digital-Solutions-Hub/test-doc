
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 16:16, @gisvlasta.
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
  [XmlType("DS_Initiative_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_Initiative_PropertyType")]
  public class DS_Initiative_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_Initiative_PropertyType"/>.
    /// </summary>
    public DS_Initiative_PropertyType() {
      _ds_Initiative  = default; //  new DS_Initiative_Type();
    }

    #endregion

    #region Public Properties

    private DS_Initiative_Type _ds_Initiative;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_Initiative", Order = 0)]
    [JsonProperty("DS_Initiative", Order = 0)]
    public DS_Initiative_Type DS_Initiative {
      get {
        return _ds_Initiative;
      }
      set {
        if (_ds_Initiative == value) {
          return;
        }
        if (_ds_Initiative == null || _ds_Initiative.Equals(value) != true) {
          _ds_Initiative = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}