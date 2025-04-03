
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:45, @XsdToCodeString.
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
  [XmlType("MI_PriorityCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_PriorityCode_PropertyType")]
  public class MI_PriorityCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_PriorityCode_PropertyType"/>.
    /// </summary>
    public MI_PriorityCode_PropertyType() {
      _mi_PriorityCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_PriorityCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_PriorityCode", Order = 0)]
    [JsonProperty("MI_PriorityCode", Order = 0)]
    public CodeListValue_Type MI_PriorityCode {
      get {
        return _mi_PriorityCode;
      }
      set {
        if (_mi_PriorityCode == value) {
          return;
        }
        if (_mi_PriorityCode == null || _mi_PriorityCode.Equals(value) != true) {
          _mi_PriorityCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
