
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:43, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_RangeDimension_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_RangeDimension_PropertyType")]
  public class MD_RangeDimension_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RangeDimension_PropertyType"/>.
    /// </summary>
    public MD_RangeDimension_PropertyType() {
      _md_RangeDimension  = default; //  new MD_RangeDimension_Type();
    }

    #endregion

    #region Public Properties

    private MD_RangeDimension_Type _md_RangeDimension;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_RangeDimension", Order = 0)]
    [JsonProperty("MD_RangeDimension", Order = 0)]
    public MD_RangeDimension_Type MD_RangeDimension {
      get {
        return _md_RangeDimension;
      }
      set {
        if (_md_RangeDimension == value) {
          return;
        }
        if (_md_RangeDimension == null || _md_RangeDimension.Equals(value) != true) {
          _md_RangeDimension = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}