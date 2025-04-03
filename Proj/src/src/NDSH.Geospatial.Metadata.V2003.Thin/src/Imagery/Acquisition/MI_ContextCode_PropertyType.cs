
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/2023, 23:36, @gisvlasta.
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
  [XmlType("MI_ContextCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_ContextCode_PropertyType")]
  public class MI_ContextCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_ContextCode_PropertyType"/>.
    /// </summary>
    public MI_ContextCode_PropertyType() {
      _mi_ContextCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_ContextCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_ContextCode", Order = 0)]
    [JsonProperty("MI_ContextCode", Order = 0)]
    public CodeListValue_Type MI_ContextCode {
      get {
        return _mi_ContextCode;
      }
      set {
        if (_mi_ContextCode == value) {
          return;
        }
        if (_mi_ContextCode == null || _mi_ContextCode.Equals(value) != true) {
          _mi_ContextCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion
  }

}
