
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:19, @gisvlasta.
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
  [XmlType("MD_GridSpatialRepresentation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_GridSpatialRepresentation_PropertyType")]
  public class MD_GridSpatialRepresentation_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GridSpatialRepresentation_PropertyType"/>.
    /// </summary>
    public MD_GridSpatialRepresentation_PropertyType() {
      _md_GridSpatialRepresentation  = default; //  new MD_GridSpatialRepresentation_Type();
    }

    #endregion

    #region Public Properties
    
    private MD_GridSpatialRepresentation_Type _md_GridSpatialRepresentation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_GridSpatialRepresentation", Order = 0)]
    [JsonProperty("MD_GridSpatialRepresentation", Order = 0)]
    public MD_GridSpatialRepresentation_Type MD_GridSpatialRepresentation {
      get {
        return _md_GridSpatialRepresentation;
      }
      set {
        if (_md_GridSpatialRepresentation == value) {
          return;
        }
        if (_md_GridSpatialRepresentation == null || _md_GridSpatialRepresentation.Equals(value) != true) {
          _md_GridSpatialRepresentation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
