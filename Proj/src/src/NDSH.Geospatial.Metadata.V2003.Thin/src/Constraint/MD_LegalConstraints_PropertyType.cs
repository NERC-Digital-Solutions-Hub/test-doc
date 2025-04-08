
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:46, @gisvlasta.
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
  [XmlType("MD_LegalConstraints_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_LegalConstraints_PropertyType")]
  public class MD_LegalConstraints_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_LegalConstraints_PropertyType"/>.
    /// </summary>
    public MD_LegalConstraints_PropertyType() {
      _md_LegalConstraints  = default; //  new MD_LegalConstraints_Type();
    }

    #endregion

    #region Public Properties

    private MD_LegalConstraints_Type _md_LegalConstraints;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_LegalConstraints", Order = 0)]
    [JsonProperty("MD_LegalConstraints", Order = 0)]
    public MD_LegalConstraints_Type MD_LegalConstraints {
      get {
        return _md_LegalConstraints;
      }
      set {
        if (_md_LegalConstraints == value) {
          return;
        }
        if (_md_LegalConstraints == null || _md_LegalConstraints.Equals(value) != true) {
          _md_LegalConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}