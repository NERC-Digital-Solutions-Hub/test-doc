
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {


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
    public List<LineStringSegmentArrayPropertyType> stopLines {
      get {
        return _stopLines;
      }
      set {
        if (_stopLines == value) {
          return;
        }
        if (_stopLines == null || _stopLines.Equals(value) != true) {
          _stopLines = value;
          OnPropertyChanged("stopLines");
        }
      }
    }

    [XmlElement("breakLines", Order = 1)]
    [JsonProperty("breakLines", Order = 1)]
    public List<LineStringSegmentArrayPropertyType> breakLines {
      get {
        return _breakLines;
      }
      set {
        if (_breakLines == value) {
          return;
        }
        if (_breakLines == null || _breakLines.Equals(value) != true) {
          _breakLines = value;
          OnPropertyChanged("breakLines");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("maxLength", Order = 2)]
    public LengthType maxLength {
      get {
        return _maxLength;
      }
      set {
        if (_maxLength == value) {
          return;
        }
        if (_maxLength == null || _maxLength.Equals(value) != true) {
          _maxLength = value;
          OnPropertyChanged("maxLength");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("controlPoint", Order = 3)]
    public TinTypeControlPoint controlPoint {
      get {
        return _controlPoint;
      }
      set {
        if (_controlPoint == value) {
          return;
        }
        if (_controlPoint == null || _controlPoint.Equals(value) != true) {
          _controlPoint = value;
          OnPropertyChanged("controlPoint");
        }
      }
    }
  }

}
