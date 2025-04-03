
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 17:41, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Application {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_StereoMate_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_StereoMate_PropertyType")]
  public class DS_StereoMate_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_StereoMate_PropertyType"/>.
    /// </summary>
    public DS_StereoMate_PropertyType() {
      _ds_StereoMate  = default; //  new DS_StereoMate_Type();
    }

    #endregion

    #region Public Properties

    private DS_StereoMate_Type _ds_StereoMate;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_StereoMate", Order = 0)]
    [JsonProperty("DS_StereoMate", Order = 0)]
    public DS_StereoMate_Type DS_StereoMate {
      get {
        return _ds_StereoMate;
      }
      set {
        if (_ds_StereoMate == value) {
          return;
        }
        if (_ds_StereoMate == null || _ds_StereoMate.Equals(value) != true) {
          _ds_StereoMate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}