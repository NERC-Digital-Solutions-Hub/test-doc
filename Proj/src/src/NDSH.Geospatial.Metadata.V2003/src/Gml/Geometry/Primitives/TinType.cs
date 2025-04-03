
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TinType")]
  public class TinType : TriangulatedSurfaceType {
    #region Private fields
    private List<LineStringSegmentArrayPropertyType> _stopLines;
    private List<LineStringSegmentArrayPropertyType> _breakLines;
    private LengthType _maxLength;
    private TinTypeControlPoint _controlPoint;
    #endregion

    /// <summary>
    /// TinType class constructor
    /// </summary>
    public TinType() {
      _controlPoint = new TinTypeControlPoint();
      _maxLength = new LengthType();
      _breakLines = new List<LineStringSegmentArrayPropertyType>();
      _stopLines = new List<LineStringSegmentArrayPropertyType>();
    }

    [XmlElement("stopLines", Order = 0)]
    [JsonProperty("stopLines", Order = 0)]
    public List<LineStringSegmentArrayPropertyType> StopLines {
      get {
        return _stopLines;
      }
      set {
        if (_stopLines == value) {
          return;
        }
        if (_stopLines == null || _stopLines.Equals(value) != true) {
          _stopLines = value;
          OnPropertyChanged("StopLines");
        }
      }
    }

    [XmlElement("breakLines", Order = 1)]
    [JsonProperty("breakLines", Order = 1)]
    public List<LineStringSegmentArrayPropertyType> BreakLines {
      get {
        return _breakLines;
      }
      set {
        if (_breakLines == value) {
          return;
        }
        if (_breakLines == null || _breakLines.Equals(value) != true) {
          _breakLines = value;
          OnPropertyChanged("BreakLines");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("maxLength", Order = 2)]
    public LengthType MaxLength {
      get {
        return _maxLength;
      }
      set {
        if (_maxLength == value) {
          return;
        }
        if (_maxLength == null || _maxLength.Equals(value) != true) {
          _maxLength = value;
          OnPropertyChanged("MaxLength");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("controlPoint", Order = 3)]
    public TinTypeControlPoint ControlPoint {
      get {
        return _controlPoint;
      }
      set {
        if (_controlPoint == value) {
          return;
        }
        if (_controlPoint == null || _controlPoint.Equals(value) != true) {
          _controlPoint = value;
          OnPropertyChanged("ControlPoint");
        }
      }
    }
  }

}
