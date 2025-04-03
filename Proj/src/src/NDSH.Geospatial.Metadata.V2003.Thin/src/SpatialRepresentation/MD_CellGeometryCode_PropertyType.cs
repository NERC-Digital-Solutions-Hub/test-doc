
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:49, @gisvlasta.
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
  [XmlType("MD_CellGeometryCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_CellGeometryCode_PropertyType")]
  public class MD_CellGeometryCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CellGeometryCode_PropertyType"/>.
    /// </summary>
    public MD_CellGeometryCode_PropertyType() {
      _md_CellGeometryCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_CellGeometryCode;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_CellGeometryCode", Order = 0)]
    [JsonProperty("MD_CellGeometryCode", Order = 0)]
    public CodeListValue_Type MD_CellGeometryCode {
      get {
        return _md_CellGeometryCode;
      }
      set {
        if (_md_CellGeometryCode == value) {
          return;
        }
        if (_md_CellGeometryCode == null || _md_CellGeometryCode.Equals(value) != true) {
          _md_CellGeometryCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
