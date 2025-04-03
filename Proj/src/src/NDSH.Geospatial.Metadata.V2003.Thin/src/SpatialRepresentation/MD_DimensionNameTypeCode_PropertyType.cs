
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:37, @gisvlasta.
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
  [XmlType("MD_DimensionNameTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_DimensionNameTypeCode_PropertyType")]
  public class MD_DimensionNameTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DimensionNameTypeCode_PropertyType"/>.
    /// </summary>
    public MD_DimensionNameTypeCode_PropertyType() {
      _md_DimensionNameTypeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties
    
    private CodeListValue_Type _md_DimensionNameTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_DimensionNameTypeCode", Order = 0)]
    [JsonProperty("MD_DimensionNameTypeCode", Order = 0)]
    public CodeListValue_Type MD_DimensionNameTypeCode {
      get {
        return _md_DimensionNameTypeCode;
      }
      set {
        if (_md_DimensionNameTypeCode == value) {
          return;
        }
        if (_md_DimensionNameTypeCode == null || _md_DimensionNameTypeCode.Equals(value) != true) {
          _md_DimensionNameTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
