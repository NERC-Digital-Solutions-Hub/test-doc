
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:16, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Distribution_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Distribution_PropertyType")]
  public class MD_Distribution_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distribution_PropertyType"/>.
    /// </summary>
    public MD_Distribution_PropertyType() {
      _md_Distribution  = default; //  new MD_Distribution_Type();
    }

    #endregion

    #region Private fields
    
    private MD_Distribution_Type _md_Distribution;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Distribution", Order = 0)]
    [JsonProperty("MD_Distribution", Order = 0)]
    public MD_Distribution_Type MD_Distribution {
      get {
        return _md_Distribution;
      }
      set {
        if (_md_Distribution == value) {
          return;
        }
        if (_md_Distribution == null || _md_Distribution.Equals(value) != true) {
          _md_Distribution = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}