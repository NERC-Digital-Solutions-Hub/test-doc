
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 01:46, @gisvlasta.
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
  [XmlType("MD_ClassificationCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ClassificationCode_PropertyType")]
  public class MD_ClassificationCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ClassificationCode_PropertyType"/>.
    /// </summary>
    public MD_ClassificationCode_PropertyType() {
      _md_ClassificationCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_ClassificationCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ClassificationCode", Order = 0)]
    [JsonProperty("MD_ClassificationCode", Order = 0)]
    public CodeListValue_Type MD_ClassificationCode {
      get {
        return _md_ClassificationCode;
      }
      set {
        if (_md_ClassificationCode == value) {
          return;
        }
        if (_md_ClassificationCode == null || _md_ClassificationCode.Equals(value) != true) {
          _md_ClassificationCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}