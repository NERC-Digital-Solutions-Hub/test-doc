
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:29, @gisvlasta.
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
  [XmlType("MD_GeometricObjects_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_GeometricObjects_PropertyType")]
  public class MD_GeometricObjects_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GeometricObjects_PropertyType"/>.
    /// </summary>
    public MD_GeometricObjects_PropertyType() {
      _md_GeometricObjects  = default; //  new MD_GeometricObjects_Type();
    }

    #endregion

    #region Public Properties
    
    private MD_GeometricObjects_Type _md_GeometricObjects;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_GeometricObjects", Order = 0)]
    [JsonProperty("MD_GeometricObjects", Order = 0)]
    public MD_GeometricObjects_Type MD_GeometricObjects {
      get {
        return _md_GeometricObjects;
      }
      set {
        if (_md_GeometricObjects == value) {
          return;
        }
        if (_md_GeometricObjects == null || _md_GeometricObjects.Equals(value) != true) {
          _md_GeometricObjects = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
