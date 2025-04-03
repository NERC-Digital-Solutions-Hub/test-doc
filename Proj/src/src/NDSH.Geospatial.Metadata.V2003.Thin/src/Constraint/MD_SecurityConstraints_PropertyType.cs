
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:53, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Constraint {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_SecurityConstraints_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_SecurityConstraints_PropertyType")]
  public class MD_SecurityConstraints_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_SecurityConstraints_PropertyType"/>.
    /// </summary>
    public MD_SecurityConstraints_PropertyType() {
      _md_SecurityConstraints  = default; //  new MD_SecurityConstraints_Type();
    }

    #endregion

    #region Public Properties
    
    private MD_SecurityConstraints_Type _md_SecurityConstraints;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_SecurityConstraints", Order = 0)]
    [JsonProperty("MD_SecurityConstraints", Order = 0)]
    public MD_SecurityConstraints_Type MD_SecurityConstraints {
      get {
        return _md_SecurityConstraints;
      }
      set {
        if (_md_SecurityConstraints == value) {
          return;
        }
        if (_md_SecurityConstraints == null || _md_SecurityConstraints.Equals(value) != true) {
          _md_SecurityConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}