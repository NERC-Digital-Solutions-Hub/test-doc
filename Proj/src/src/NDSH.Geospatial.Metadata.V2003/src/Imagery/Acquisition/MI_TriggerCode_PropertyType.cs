
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:47, @gisvlasta.
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
  [XmlType("MI_TriggerCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_TriggerCode_PropertyType")]
  public class MI_TriggerCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_TriggerCode_PropertyType"/>.
    /// </summary>
    public MI_TriggerCode_PropertyType() {
      _mi_TriggerCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_TriggerCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_TriggerCode", Order = 0)]
    [JsonProperty("MI_TriggerCode", Order = 0)]
    public CodeListValue_Type MI_TriggerCode {
      get {
        return _mi_TriggerCode;
      }
      set {
        if (_mi_TriggerCode == value) {
          return;
        }
        if (_mi_TriggerCode == null || _mi_TriggerCode.Equals(value) != true) {
          _mi_TriggerCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
