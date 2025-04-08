
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:40, @gisvlasta.
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
  [XmlType("MD_ImagingConditionCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ImagingConditionCode_PropertyType")]
  public class MD_ImagingConditionCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ImagingConditionCode_PropertyType"/>.
    /// </summary>
    public MD_ImagingConditionCode_PropertyType() {
      _md_ImagingConditionCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_ImagingConditionCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ImagingConditionCode", Order = 0)]
    [JsonProperty("MD_ImagingConditionCode", Order = 0)]
    public CodeListValue_Type MD_ImagingConditionCode {
      get {
        return _md_ImagingConditionCode;
      }
      set {
        if (_md_ImagingConditionCode == value) {
          return;
        }
        if (_md_ImagingConditionCode == null || _md_ImagingConditionCode.Equals(value) != true) {
          _md_ImagingConditionCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}