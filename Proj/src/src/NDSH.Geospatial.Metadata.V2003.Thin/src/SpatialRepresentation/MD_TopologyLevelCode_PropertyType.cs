
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 03:50, @gisvlasta.
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
  [XmlType("MD_TopologyLevelCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_TopologyLevelCode_PropertyType")]
  public class MD_TopologyLevelCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_TopologyLevelCode_PropertyType"/>.
    /// </summary>
    public MD_TopologyLevelCode_PropertyType() {
      _md_TopologyLevelCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_TopologyLevelCode;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_TopologyLevelCode", Order = 0)]
    [JsonProperty("MD_TopologyLevelCode", Order = 0)]
    public CodeListValue_Type MD_TopologyLevelCode {
      get {
        return _md_TopologyLevelCode;
      }
      set {
        if (_md_TopologyLevelCode == value) {
          return;
        }
        if (_md_TopologyLevelCode == null || _md_TopologyLevelCode.Equals(value) != true) {
          _md_TopologyLevelCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
