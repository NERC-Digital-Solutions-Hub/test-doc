
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:23, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Georectified_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Georectified_PropertyType")]
  public class MD_Georectified_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georectified_PropertyType"/>.
    /// </summary>
    public MD_Georectified_PropertyType() {
      _md_Georectified  = default; //  new MD_Georectified_Type();
    }

    #endregion

    #region Public Properties
    
    private MD_Georectified_Type _md_Georectified;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Georectified", Order = 0)]
    [JsonProperty("MD_Georectified", Order = 0)]
    public MD_Georectified_Type MD_Georectified {
      get {
        return _md_Georectified;
      }
      set {
        if (_md_Georectified == value) {
          return;
        }
        if (_md_Georectified == null || _md_Georectified.Equals(value) != true) {
          _md_Georectified = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
