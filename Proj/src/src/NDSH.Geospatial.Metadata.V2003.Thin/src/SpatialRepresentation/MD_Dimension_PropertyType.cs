
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:45, @gisvlasta.
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
  [XmlType("MD_Dimension_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Dimension_PropertyType")]
  public class MD_Dimension_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Dimension_PropertyType"/>.
    /// </summary>
    public MD_Dimension_PropertyType() {
      _md_Dimension  = default; //  new MD_Dimension_Type();
    }

    #endregion

    #region Public Properties

    private MD_Dimension_Type _md_Dimension;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Dimension", Order = 0)]
    [JsonProperty("MD_Dimension", Order = 0)]
    public MD_Dimension_Type MD_Dimension {
      get {
        return _md_Dimension;
      }
      set {
        if (_md_Dimension == value) {
          return;
        }
        if (_md_Dimension == null || _md_Dimension.Equals(value) != true) {
          _md_Dimension = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
