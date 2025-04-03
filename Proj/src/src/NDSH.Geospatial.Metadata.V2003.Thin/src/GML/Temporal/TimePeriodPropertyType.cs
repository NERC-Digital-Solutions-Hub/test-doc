﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal {

  /// <summary>
  /// gml:TimePeriodPropertyType provides for associating a gml:TimePeriod with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimePeriodPropertyType")]
  public class TimePeriodPropertyType : Model {
    #region Private fields
    private TimePeriodType _timePeriod;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimePeriodPropertyType class constructor
    /// </summary>
    public TimePeriodPropertyType() {
      _timePeriod = new TimePeriodType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimePeriod", Order = 0)]
    public TimePeriodType TimePeriod {
      get {
        return _timePeriod;
      }
      set {
        if (_timePeriod == value) {
          return;
        }
        if (_timePeriod == null || _timePeriod.Equals(value) != true) {
          _timePeriod = value;
          OnPropertyChanged("TimePeriod");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string nilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("nilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string remoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("remoteSchema");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }
  }

}
