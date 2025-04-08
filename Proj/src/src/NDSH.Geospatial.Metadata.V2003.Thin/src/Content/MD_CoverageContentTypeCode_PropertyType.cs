
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:12, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_CoverageContentTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_CoverageContentTypeCode_PropertyType")]
  public class MD_CoverageContentTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CoverageContentTypeCode_PropertyType"/>.
    /// </summary>
    public MD_CoverageContentTypeCode_PropertyType() {
      _md_CoverageContentTypeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_CoverageContentTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_CoverageContentTypeCode", Order = 0)]
    [JsonProperty("MD_CoverageContentTypeCode", Order = 0)]
    public CodeListValue_Type MD_CoverageContentTypeCode {
      get {
        return _md_CoverageContentTypeCode;
      }
      set {
        if (_md_CoverageContentTypeCode == value) {
          return;
        }
        if (_md_CoverageContentTypeCode == null || _md_CoverageContentTypeCode.Equals(value) != true) {
          _md_CoverageContentTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}