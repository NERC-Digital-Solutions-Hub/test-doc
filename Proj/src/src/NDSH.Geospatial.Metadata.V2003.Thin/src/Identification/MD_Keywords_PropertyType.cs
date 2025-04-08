
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:16, @gisvlasta.
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
  [XmlType("MD_Keywords_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Keywords_PropertyType")]
  public class MD_Keywords_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Keywords_PropertyType"/>.
    /// </summary>
    public MD_Keywords_PropertyType() {
      _md_Keywords  = default; //  new MD_Keywords_Type();
    }

    #endregion

    #region Public Properties

    private MD_Keywords_Type _md_Keywords;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Keywords", Order = 0)]
    [JsonProperty("MD_Keywords", Order = 0)]
    public MD_Keywords_Type MD_Keywords {
      get {
        return _md_Keywords;
      }
      set {
        if (_md_Keywords == value) {
          return;
        }
        if (_md_Keywords == null || _md_Keywords.Equals(value) != true) {
          _md_Keywords = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
