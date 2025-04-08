using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Grids {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RectifiedGridType")]
  public class RectifiedGridType : GridType {
    #region Private fields
    private PointPropertyType _origin;
    private List<VectorType> _offsetVector;
    #endregion

    /// <summary>
    /// RectifiedGridType class constructor
    /// </summary>
    public RectifiedGridType() {
      _offsetVector = new List<VectorType>();
      _origin = new PointPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("origin", Order = 0)]
    public PointPropertyType Origin {
      get {
        return _origin;
      }
      set {
        if (_origin == value) {
          return;
        }
        if (_origin == null || _origin.Equals(value) != true) {
          _origin = value;
          OnPropertyChanged("Origin");
        }
      }
    }

    [XmlElement("offsetVector", Order = 1)]
    [JsonProperty("offsetVector", Order = 1)]
    public List<VectorType> OffsetVector {
      get {
        return _offsetVector;
      }
      set {
        if (_offsetVector == value) {
          return;
        }
        if (_offsetVector == null || _offsetVector.Equals(value) != true) {
          _offsetVector = value;
          OnPropertyChanged("OffsetVector");
        }
      }
    }
  }
}
