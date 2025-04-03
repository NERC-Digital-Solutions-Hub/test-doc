using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Gml.Direction;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature.Dynamic {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MovingObjectStatusType")]
  public class MovingObjectStatusType : AbstractTimeSliceType {
    #region Private fields
    private object _item;
    private MeasureType _speed;
    private DirectionPropertyType _bearing;
    private MeasureType _acceleration;
    private MeasureType _elevation;
    private StringOrRefType _status;
    private ReferenceType _statusReference;
    #endregion

    /// <summary>
    /// MovingObjectStatusType class constructor
    /// </summary>
    public MovingObjectStatusType() {
      _statusReference = default; // new ReferenceType();
      _status = default; // new StringOrRefType();
      _elevation = default; // new MeasureType();
      _acceleration = default; // new MeasureType();
      _bearing = default; // new DirectionPropertyType();
      _speed = default; // new MeasureType();
    }

    [XmlElement("location", typeof(LocationPropertyType), Order = 0)]
    [XmlElement("locationName", typeof(CodeType), Order = 0)]
    [XmlElement("locationReference", typeof(ReferenceType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("position", typeof(GeometryPropertyType), Order = 0)]
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

    [XmlElement(Order = 1)]
    [JsonProperty("speed", Order = 1)]
    public MeasureType Speed {
      get {
        return _speed;
      }
      set {
        if (_speed == value) {
          return;
        }
        if (_speed == null || _speed.Equals(value) != true) {
          _speed = value;
          OnPropertyChanged("Speed");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("bearing", Order = 2)]
    public DirectionPropertyType Bearing {
      get {
        return _bearing;
      }
      set {
        if (_bearing == value) {
          return;
        }
        if (_bearing == null || _bearing.Equals(value) != true) {
          _bearing = value;
          OnPropertyChanged("Bearing");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("acceleration", Order = 3)]
    public MeasureType Acceleration {
      get {
        return _acceleration;
      }
      set {
        if (_acceleration == value) {
          return;
        }
        if (_acceleration == null || _acceleration.Equals(value) != true) {
          _acceleration = value;
          OnPropertyChanged("Acceleration");
        }
      }
    }

    [XmlElement(Order = 4)]
    [JsonProperty("elevation", Order = 4)]
    public MeasureType Elevation {
      get {
        return _elevation;
      }
      set {
        if (_elevation == value) {
          return;
        }
        if (_elevation == null || _elevation.Equals(value) != true) {
          _elevation = value;
          OnPropertyChanged("Elevation");
        }
      }
    }

    [XmlElement(Order = 5)]
    [JsonProperty("status", Order = 5)]
    public StringOrRefType Status {
      get {
        return _status;
      }
      set {
        if (_status == value) {
          return;
        }
        if (_status == null || _status.Equals(value) != true) {
          _status = value;
          OnPropertyChanged("Status");
        }
      }
    }

    [XmlElement(Order = 6)]
    [JsonProperty("statusReference", Order = 6)]
    public ReferenceType StatusReference {
      get {
        return _statusReference;
      }
      set {
        if (_statusReference == value) {
          return;
        }
        if (_statusReference == null || _statusReference.Equals(value) != true) {
          _statusReference = value;
          OnPropertyChanged("StatusReference");
        }
      }
    }
  }
}
