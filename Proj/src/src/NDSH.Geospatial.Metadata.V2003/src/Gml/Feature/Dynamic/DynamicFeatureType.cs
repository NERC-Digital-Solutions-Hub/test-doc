using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature.Dynamic {

  [XmlInclude(typeof(DynamicFeatureCollectionType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DynamicFeatureType")]
  public class DynamicFeatureType : AbstractFeatureType {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private HistoryPropertyType _history;
    private StringOrRefType _dataSource;
    private ReferenceType _dataSourceReference;
    #endregion

    /// <summary>
    /// DynamicFeatureType class constructor
    /// </summary>
    public DynamicFeatureType() {
      _dataSourceReference = default; // new ReferenceType();
      _dataSource = default; // new StringOrRefType();
      _history = default; // new HistoryPropertyType();
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
    [JsonProperty("history", Order = 1)]
    public HistoryPropertyType History {
      get {
        return _history;
      }
      set {
        if (_history == value) {
          return;
        }
        if (_history == null || _history.Equals(value) != true) {
          _history = value;
          OnPropertyChanged("History");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("dataSource", Order = 2)]
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

    [XmlElement(Order = 3)]
    [JsonProperty("dataSourceReference", Order = 3)]
    public ReferenceType DataSourceReference {
      get {
        return _dataSourceReference;
      }
      set {
        if (_dataSourceReference == value) {
          return;
        }
        if (_dataSourceReference == null || _dataSourceReference.Equals(value) != true) {
          _dataSourceReference = value;
          OnPropertyChanged("DataSourceReference");
        }
      }
    }
  }


}
