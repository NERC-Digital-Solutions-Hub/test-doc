
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 18:19, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Band_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Band_PropertyType")]
  public class MD_Band_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Band_PropertyType"/>.
    /// </summary>
    public MD_Band_PropertyType() {
      _md_Band  = default; //  new MD_Band_Type();
    }

    #endregion

    #region Public Properties

    private MD_Band_Type _md_Band;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Band", Order = 0)]
    [JsonProperty("MD_Band", Order = 0)]
    public MD_Band_Type MD_Band {
      get {
        return _md_Band;
      }
      set {
        if (_md_Band == value) {
          return;
        }
        if (_md_Band == null || _md_Band.Equals(value) != true) {
          _md_Band = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}