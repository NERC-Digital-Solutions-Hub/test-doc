
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 19:39, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Medium_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Medium_PropertyType")]
  public class MD_Medium_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Medium_PropertyType"/>.
    /// </summary>
    public MD_Medium_PropertyType() {
      _md_Medium  = default; //  new MD_Medium_Type();
    }

    #endregion

    #region Public Properties
    
    private MD_Medium_Type _md_Medium;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Medium", Order = 0)]
    [JsonProperty("MD_Medium", Order = 0)]
    public MD_Medium_Type MD_Medium {
      get {
        return _md_Medium;
      }
      set {
        if (_md_Medium == value) {
          return;
        }
        if (_md_Medium == null || _md_Medium.Equals(value) != true) {
          _md_Medium = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}