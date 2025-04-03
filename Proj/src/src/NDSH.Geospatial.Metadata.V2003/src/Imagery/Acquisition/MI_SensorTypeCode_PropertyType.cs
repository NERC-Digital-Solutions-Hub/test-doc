
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:46, @gisvlasta.
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
  [XmlType("MI_SensorTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_SensorTypeCode_PropertyType")]
  public class MI_SensorTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_SensorTypeCode_PropertyType"/>.
    /// </summary>
    public MI_SensorTypeCode_PropertyType() {
      _mi_SensorTypeCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_SensorTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_SensorTypeCode", Order = 0)]
    [JsonProperty("MI_SensorTypeCode", Order = 0)]
    public CodeListValue_Type MI_SensorTypeCode {
      get {
        return _mi_SensorTypeCode;
      }
      set {
        if (_mi_SensorTypeCode == value) {
          return;
        }
        if (_mi_SensorTypeCode == null || _mi_SensorTypeCode.Equals(value) != true) {
          _mi_SensorTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
