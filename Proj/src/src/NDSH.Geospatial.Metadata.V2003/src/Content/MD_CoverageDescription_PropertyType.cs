
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 03:21, @gisvlasta.
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
  [XmlType("MD_CoverageDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_CoverageDescription_PropertyType")]
  public class MD_CoverageDescription_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CoverageDescription_PropertyType"/>.
    /// </summary>
    public MD_CoverageDescription_PropertyType() {
      _md_CoverageDescription  = default; //  new MD_CoverageDescription_Type();
    }

    #endregion

    #region Public Properties

    private MD_CoverageDescription_Type _md_CoverageDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_CoverageDescription", Order = 0)]
    [JsonProperty("MD_CoverageDescription", Order = 0)]
    public MD_CoverageDescription_Type MD_CoverageDescription {
      get {
        return _md_CoverageDescription;
      }
      set {
        if (_md_CoverageDescription == value) {
          return;
        }
        if (_md_CoverageDescription == null || _md_CoverageDescription.Equals(value) != true) {
          _md_CoverageDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}