using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature.Dynamic {

  [XmlInclude(typeof(MovingObjectStatusType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeSliceType")]
  public abstract class AbstractTimeSliceType : AbstractGMLType {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private StringOrRefType _dataSource;
    #endregion

    /// <summary>
    /// AbstractTimeSliceType class constructor
    /// </summary>
    public AbstractTimeSliceType() {
      _dataSource = default; // new StringOrRefType();
      _validTime = default; // new TimePrimitivePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("validTime", Order = 0)]
    public TimePrimitivePropertyType ValidTime {
      get {
        return _validTime;
      }
      set {
        if (_validTime == value) {
          return;
        }
        if (_validTime == null || _validTime.Equals(value) != true) {
          _validTime = value;
          OnPropertyChanged("ValidTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("dataSource", Order = 1)]
    public StringOrRefType DataSource {
      get {
        return _dataSource;
      }
      set {
        if (_dataSource == value) {
          return;
        }
        if (_dataSource == null || _dataSource.Equals(value) != true) {
          _dataSource = value;
          OnPropertyChanged("DataSource");
        }
      }
    }
  }
}
