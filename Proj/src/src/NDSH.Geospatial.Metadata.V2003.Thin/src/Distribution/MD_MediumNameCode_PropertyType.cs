
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:50, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_MediumNameCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_MediumNameCode_PropertyType")]
  public class MD_MediumNameCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MediumNameCode_PropertyType"/>.
    /// </summary>
    public MD_MediumNameCode_PropertyType() {
      _md_MediumNameCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_MediumNameCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_MediumNameCode", Order = 0)]
    [JsonProperty("MD_MediumNameCode", Order = 0)]
    public CodeListValue_Type MD_MediumNameCode {
      get {
        return _md_MediumNameCode;
      }
      set {
        if (_md_MediumNameCode == value) {
          return;
        }
        if (_md_MediumNameCode == null || _md_MediumNameCode.Equals(value) != true) {
          _md_MediumNameCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}