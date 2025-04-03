using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimePeriodType")]
  public class TimePeriodType : AbstractTimeGeometricPrimitiveType {
    #region Private fields
    private object _item;
    private object _item1;
    private string _duration;
    private TimeIntervalLengthType _timeInterval;
    #endregion

    /// <summary>
    /// TimePeriodType class constructor
    /// </summary>
    public TimePeriodType() {
      _timeInterval = new TimeIntervalLengthType();
    }

    [XmlElement("begin", typeof(TimeInstantPropertyType), Order = 0)]
    [XmlElement("beginPosition", typeof(TimePositionType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement("end", typeof(TimeInstantPropertyType), Order = 1)]
    [XmlElement("endPosition", typeof(TimePositionType), Order = 1)]
    public object Item1 {
      get {
        return _item1;
      }
      set {
        if (_item1 == value) {
          return;
        }
        if (_item1 == null || _item1.Equals(value) != true) {
          _item1 = value;
          OnPropertyChanged("Item1");
        }
      }
    }

    [XmlElement(DataType = "duration", Order = 2)]
    [JsonProperty("duration", Order = 2)]
    public string duration {
      get {
        return _duration;
      }
      set {
        if (_duration == value) {
          return;
        }
        if (_duration == null || _duration.Equals(value) != true) {
          _duration = value;
          OnPropertyChanged("duration");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("timeInterval", Order = 3)]
    public TimeIntervalLengthType timeInterval {
      get {
        return _timeInterval;
      }
      set {
        if (_timeInterval == value) {
          return;
        }
        if (_timeInterval == null || _timeInterval.Equals(value) != true) {
          _timeInterval = value;
          OnPropertyChanged("timeInterval");
        }
      }
    }
  }

}
