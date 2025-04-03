
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:42, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Georeferenceable_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Georeferenceable_PropertyType")]
  public class MD_Georeferenceable_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Georeferenceable_PropertyType"/>.
    /// </summary>
    public MD_Georeferenceable_PropertyType() {
      _md_Georeferenceable  = default; //  new MD_Georeferenceable_Type();
    }

    #endregion
    
    #region Public Properties
    
    private MD_Georeferenceable_Type _md_Georeferenceable;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Georeferenceable", Order = 0)]
    [JsonProperty("MD_Georeferenceable", Order = 0)]
    public MD_Georeferenceable_Type MD_Georeferenceable {
      get {
        return _md_Georeferenceable;
      }
      set {
        if (_md_Georeferenceable == value) {
          return;
        }
        if (_md_Georeferenceable == null || _md_Georeferenceable.Equals(value) != true) {
          _md_Georeferenceable = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
