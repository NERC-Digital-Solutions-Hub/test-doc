
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 17:29, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Application {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_Sensor_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_Sensor_PropertyType")]
  public class DS_Sensor_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_Sensor_PropertyType"/>.
    /// </summary>
    public DS_Sensor_PropertyType() {
      _ds_Sensor  = default; //  new DS_Sensor_Type();
    }

    #endregion

    #region Public Proeprties

    private DS_Sensor_Type _ds_Sensor;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_Sensor", Order = 0)]
    [JsonProperty("DS_Sensor", Order = 0)]
    public DS_Sensor_Type DS_Sensor {
      get {
        return _ds_Sensor;
      }
      set {
        if (_ds_Sensor == value) {
          return;
        }
        if (_ds_Sensor == null || _ds_Sensor.Equals(value) != true) {
          _ds_Sensor = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}