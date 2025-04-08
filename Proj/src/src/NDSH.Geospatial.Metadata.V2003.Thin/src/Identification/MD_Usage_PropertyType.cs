
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 03:11, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Usage_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Usage_PropertyType")]
  public class MD_Usage_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Usage_PropertyType"/>.
    /// </summary>
    public MD_Usage_PropertyType() {
      _md_Usage  = default; //  new MD_Usage_Type();
    }

    #endregion

    #region Public Properties

    private MD_Usage_Type _md_Usage;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Usage", Order = 0)]
    [JsonProperty("MD_Usage", Order = 0)]
    public MD_Usage_Type MD_Usage {
      get {
        return _md_Usage;
      }
      set {
        if (_md_Usage == value) {
          return;
        }
        if (_md_Usage == null || _md_Usage.Equals(value) != true) {
          _md_Usage = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
