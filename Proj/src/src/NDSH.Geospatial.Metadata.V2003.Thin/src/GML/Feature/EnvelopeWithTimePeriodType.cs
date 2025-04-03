
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature
{


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EnvelopeWithTimePeriodType")]
  public class EnvelopeWithTimePeriodType : EnvelopeType {
    #region Private fields
    private TimePositionType _beginPosition;
    private TimePositionType _endPosition;
    private string _frame;
    #endregion

    /// <summary>
    /// EnvelopeWithTimePeriodType class constructor
    /// </summary>
    public EnvelopeWithTimePeriodType() {
      _endPosition = new TimePositionType();
      _beginPosition = new TimePositionType();
      _frame = "#ISO-8601";
    }

    [XmlElement(Order = 0)]
    [JsonProperty("beginPosition", Order = 0)]
    public TimePositionType beginPosition {
      get {
        return _beginPosition;
      }
      set {
        if (_beginPosition == value) {
          return;
        }
        if (_beginPosition == null || _beginPosition.Equals(value) != true) {
          _beginPosition = value;
          OnPropertyChanged("beginPosition");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("endPosition", Order = 1)]
    public TimePositionType endPosition {
      get {
        return _endPosition;
      }
      set {
        if (_endPosition == value) {
          return;
        }
        if (_endPosition == null || _endPosition.Equals(value) != true) {
          _endPosition = value;
          OnPropertyChanged("endPosition");
        }
      }
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    [JsonProperty("frame")]
    public string frame {
      get {
        return _frame;
      }
      set {
        if (_frame == value) {
          return;
        }
        if (_frame == null || _frame.Equals(value) != true) {
          _frame = value;
          OnPropertyChanged("frame");
        }
      }
    }
  }
}