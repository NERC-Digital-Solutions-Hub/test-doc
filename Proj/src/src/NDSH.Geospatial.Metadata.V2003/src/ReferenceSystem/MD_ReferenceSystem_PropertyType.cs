
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:27, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ReferenceSystem_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ReferenceSystem_PropertyType")]
  public class MD_ReferenceSystem_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ReferenceSystem_PropertyType"/>.
    /// </summary>
    public MD_ReferenceSystem_PropertyType() {
      _md_ReferenceSystem  = default; //  new MD_ReferenceSystem_Type();
    }

    #endregion

    #region Private fields

    private MD_ReferenceSystem_Type _md_ReferenceSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ReferenceSystem", Order = 0)]
    [JsonProperty("MD_ReferenceSystem", Order = 0)]
    public MD_ReferenceSystem_Type MD_ReferenceSystem {
      get {
        return _md_ReferenceSystem;
      }
      set {
        if (_md_ReferenceSystem == value) {
          return;
        }
        if (_md_ReferenceSystem == null || _md_ReferenceSystem.Equals(value) != true) {
          _md_ReferenceSystem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
