
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:39, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_GeometryTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_GeometryTypeCode_PropertyType")]
  public class MI_GeometryTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GeometryTypeCode_PropertyType"/>.
    /// </summary>
    public MI_GeometryTypeCode_PropertyType() {
      _mi_GeometryTypeCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_GeometryTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_GeometryTypeCode", Order = 0)]
    [JsonProperty("MI_GeometryTypeCode", Order = 0)]
    public CodeListValue_Type MI_GeometryTypeCode {
      get {
        return _mi_GeometryTypeCode;
      }
      set {
        if (_mi_GeometryTypeCode == value) {
          return;
        }
        if (_mi_GeometryTypeCode == null || _mi_GeometryTypeCode.Equals(value) != true) {
          _mi_GeometryTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
