using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature {


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
    public TimePositionType BeginPosition {
      get {
        return _beginPosition;
      }
      set {
        if (_beginPosition == value) {
          return;
        }
        if (_beginPosition == null || _beginPosition.Equals(value) != true) {
          _beginPosition = value;
          OnPropertyChanged("BeginPosition");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("endPosition", Order = 1)]
    public TimePositionType EndPosition {
      get {
        return _endPosition;
      }
      set {
        if (_endPosition == value) {
          return;
        }
        if (_endPosition == null || _endPosition.Equals(value) != true) {
          _endPosition = value;
          OnPropertyChanged("EndPosition");
        }
      }
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    [JsonProperty("frame")]
    public string Frame {
      get {
        return _frame;
      }
      set {
        if (_frame == value) {
          return;
        }
        if (_frame == null || _frame.Equals(value) != true) {
          _frame = value;
          OnPropertyChanged("Frame");
        }
      }
    }
  }
}
