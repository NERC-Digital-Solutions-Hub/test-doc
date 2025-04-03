
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:07, @gisvlasta.
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
  [XmlType("MD_VectorSpatialRepresentation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_VectorSpatialRepresentation_PropertyType")]
  public class MD_VectorSpatialRepresentation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_VectorSpatialRepresentation_PropertyType"/>.
    /// </summary>
    public MD_VectorSpatialRepresentation_PropertyType() {
      _md_VectorSpatialRepresentation  = default; //  new MD_VectorSpatialRepresentation_Type();
    }

    #endregion

    #region Public Properties

    private MD_VectorSpatialRepresentation_Type _md_VectorSpatialRepresentation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_VectorSpatialRepresentation", Order = 0)]
    [JsonProperty("MD_VectorSpatialRepresentation", Order = 0)]
    public MD_VectorSpatialRepresentation_Type MD_VectorSpatialRepresentation {
      get {
        return _md_VectorSpatialRepresentation;
      }
      set {
        if (_md_VectorSpatialRepresentation == value) {
          return;
        }
        if (_md_VectorSpatialRepresentation == null || _md_VectorSpatialRepresentation.Equals(value) != true) {
          _md_VectorSpatialRepresentation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
