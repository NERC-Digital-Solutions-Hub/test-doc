
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:40, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_ObjectiveTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_ObjectiveTypeCode_PropertyType")]
  public class MI_ObjectiveTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_ObjectiveTypeCode_PropertyType"/>.
    /// </summary>
    public MI_ObjectiveTypeCode_PropertyType() {
      _mi_ObjectiveTypeCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_ObjectiveTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_ObjectiveTypeCode", Order = 0)]
    [JsonProperty("MI_ObjectiveTypeCode", Order = 0)]
    public CodeListValue_Type MI_ObjectiveTypeCode {
      get {
        return _mi_ObjectiveTypeCode;
      }
      set {
        if (_mi_ObjectiveTypeCode == value) {
          return;
        }
        if (_mi_ObjectiveTypeCode == null || _mi_ObjectiveTypeCode.Equals(value) != true) {
          _mi_ObjectiveTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion
  }

}
