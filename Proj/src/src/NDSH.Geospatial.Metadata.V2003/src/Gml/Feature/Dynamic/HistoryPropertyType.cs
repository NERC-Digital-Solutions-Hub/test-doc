using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature.Dynamic {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("HistoryPropertyType")]
  public class HistoryPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractTimeSliceType> _abstractTimeSlice;
    private bool _owns;
    #endregion

    /// <summary>
    /// HistoryPropertyType class constructor
    /// </summary>
    public HistoryPropertyType() {
      _abstractTimeSlice = default; // new List<AbstractTimeSliceType>();
      _owns = default; // false;
    }

    [XmlElement("AbstractTimeSlice", Order = 0)]
    [JsonProperty("AbstractTimeSlice", Order = 0)]
    public List<AbstractTimeSliceType> AbstractTimeSlice {
      get {
        return _abstractTimeSlice;
      }
      set {
        if (_abstractTimeSlice == value) {
          return;
        }
        if (_abstractTimeSlice == null || _abstractTimeSlice.Equals(value) != true) {
          _abstractTimeSlice = value;
          OnPropertyChanged("AbstractTimeSlice");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }
  }
}
