
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:59, @gisvlasta.
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
  [XmlType("MD_SpatialRepresentation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_SpatialRepresentation_PropertyType")]
  public class MD_SpatialRepresentation_PropertyType : ObjectReference_PropertyType {

    #region Public Properties
    
    private AbstractMD_SpatialRepresentation_Type _abstractMD_SpatialRepresentation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractMD_SpatialRepresentation", Order = 0)]
    [JsonProperty("AbstractMD_SpatialRepresentation", Order = 0)]
    public AbstractMD_SpatialRepresentation_Type AbstractMD_SpatialRepresentation {
      get {
        return _abstractMD_SpatialRepresentation;
      }
      set {
        if (_abstractMD_SpatialRepresentation == value) {
          return;
        }
        if (_abstractMD_SpatialRepresentation == null || _abstractMD_SpatialRepresentation.Equals(value) != true) {
          _abstractMD_SpatialRepresentation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
